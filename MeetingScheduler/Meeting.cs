using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Meeting
    {
        public string Name = "Default Meeting";
        public string Details = "A meeting is happening";
        public DateTime StartTime;
        public int Length;  // in hours
        public User Initiator;
        public HashSet<Participant> Participants;
        public DateTime EndTime
        {
            get
            {
                return StartTime + new TimeSpan(Length, 0, 0);
            }

            set
            {
                Length = (value.Hour - StartTime.Hour);
            }
        }

        public Meeting(User initiator) {
            this.StartTime = System.DateTime.Today + new TimeSpan(8, 0, 0);
            this.Length = 1;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }
        public Meeting(User initiator, string name, DateTime time, int length = 1)
        {
            this.Name = name;
            this.StartTime = time;
            this.Length = length;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }

        public Participant GetParticipant(User u) {
            foreach (Participant p in this.Participants) {
                if (p.user == u) {
                    return p;
                }
            }

            return null;
        }

        public int Column
        {
            get
            {
                return StartTime.Hour - 7;
            }
        }

        public int Row
        {
            get
            {
                return (int)StartTime.DayOfWeek + 1;
            }
        }

        public HashSet<Participant> ImportantParticipants
        {
            get
            {
                HashSet<Participant> output = new HashSet<Participant>();

                foreach (Participant p in this.Participants)
                {
                    if (p.status == 1)
                        output.Add(p);
                }

                return output;
            }
        }

        public HashSet<Participant> GuestSpeakers
        {
            get
            {
                HashSet<Participant> output = new HashSet<Participant>();

                foreach (Participant p in this.Participants)
                {
                    if (p.status == 2)
                        output.Add(p);
                }

                return output;
            }
        }

        public Participant GuestSpeaker {
            get {
                foreach (Participant p in this.Participants)
                {
                    if (p.status == 2)
                    {
                        return p;
                    }
                }
                return null;
            }
            set
            {
                foreach (Participant p in this.Participants)
                {
                    //if this participant is the one being set, their status becomes 2
                    //otherwise if their status is 2, make them standard
                    //otherwise keep their status as it is (std or important)
                    p.status = p == value ? 2 : p.status==2 ? 0 :p.status;
                }
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Compares this meeting with another meeting, determining which is more important as per our conflict resolution flowchart.
        ///
        /// Separating this out into its own function that returns a number is similar to how strcmp works in C++.
        /// This facilitates easy calculation of any priority comparison operation:
        ///
        ///  a == b  |  a.ComparePriority(b) == 0
        ///  a != b  |  a.ComparePriority(b) != 0
        ///  a > b   |  a.ComparePriority(b) < 0
        ///  a >= b  |  a.ComparePriority(b) <= 0
        ///  a < b   |  a.ComparePriority(b) > 0
        ///  a <= b  |  a.ComparePriority(b) >= 0
        ///
        /// I would implement these as direct operators on the class, but it would override normal comparison,
        /// making it difficult to check meetings against e.g. null
        ///
        /// </summary>
        /// <param name="other">The meeting to compare to</param>
        /// <returns>-1 if this meeting has higher priority, 1 if the other meeting has higher priority, 0 if the two meetings have the same priority.</returns>
        public int ComparePriority(Meeting other)
        {
            if (this.GuestSpeakers.Count > other.GuestSpeakers.Count)
                return -1;
            else if (this.GuestSpeakers.Count < other.GuestSpeakers.Count)
                return 1;
            else if (this.ImportantParticipants.Count > other.ImportantParticipants.Count)
                return -1;
            else if (this.ImportantParticipants.Count < other.ImportantParticipants.Count)
                return 1;
            else if (this.Participants.Count > other.Participants.Count)
                return -1;
            else if (this.Participants.Count < other.Participants.Count)
                return 1;

            return 0;
        }

        /// <summary>
        /// Checks whether this meeting intersects with another meeting (their time slots conflict).
        /// </summary>
        /// <param name="other">The meeting to check intersection against</param>
        /// <returns>Whether the two meetings intersect (they take place at the same time for at least one slot)</returns>
        public bool Intersects(Meeting other)
        {
            return StartTime >= other.EndTime != other.StartTime < EndTime;
        }

        /// <summary>
        /// Checks whether this meeting would intersects with another meeting if it was moved to a given start time.
        /// </summary>
        /// <param name="other">The meeting to check intersection against</param>
        /// <returns>Whether the two meetings would intersect (they would take place at the same time for at least one slot)</returns>
        public bool WouldIntersect(DateTime newStartTime, Meeting other)
        {
            return newStartTime >= other.EndTime != other.StartTime < (newStartTime + new TimeSpan(Length, 0, 0));
        }
    }
}
