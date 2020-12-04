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

        public override string ToString()
        {
            return this.Name;
        }
    }
}
