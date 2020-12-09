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
        public bool HasBeenMoved = false;
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

        public HashSet<Equipment> EquipmentRequests
        {
            get
            {
                HashSet<Equipment> output = new HashSet<Equipment>();
                foreach (Participant p in this.Participants) {
                    if (p.Attendance)
                    {
                        foreach (Equipment e in p.equipmentRequests)
                        {
                            output.Add(e);
                        }
                    }
                }
                return output;
            }
        }

        public HashSet<Location> LocationPreferences
        {
            get
            {
                HashSet<Location> output = new HashSet<Location>();
                foreach (Participant p in this.Participants)
                {
                    if (p.Attendance)
                    {
                        foreach (Location l in p.locationPreferences)
                        {
                            output.Add(l);
                        }
                    }
                }
                return output;
            }
        }

        public int CapacityNeeded
        {
            get
            {
                int total = 0;
                foreach (Participant p in this.Participants)
                {
                    if (p.Attendance == true)
                    {
                        ++total;
                    }
                }
                foreach (Equipment equip in this.EquipmentRequests)
                {
                    total += equip.requiresCapacity;
                }
                return total;
            }
        }
        public HashSet<Location> PotentialLocations {
            get
            {
                HashSet<Location> output = new HashSet<Location>();
                foreach (Location loc in AllLocations.Locations)
                {
                    //if there isn't enough capacity in this room, skip it
                    if (loc.capacity < this.CapacityNeeded) { break; }

                    //then check the equipmentRequests
                    bool equipmentSatisfied = true;

                    foreach (Equipment e in EquipmentRequests)
                    {
                        if (!loc.fixedEquipment.Contains(e)) {
                            if (!AllEquipment.IsPortable.Contains(e))
                                equipmentSatisfied = false;
                        }
                    }

                    if (!equipmentSatisfied) continue;

                    output.Add(loc);
                }
                return output;
            }
        }

        public HashSet<Equipment> UnavailablePortableEquipment
        {
            get
            {
                HashSet<Equipment> output = new HashSet<Equipment>();

                foreach (Equipment e in EquipmentRequests)
                {
                    if (AllEquipment.OnlyOne.Contains(e))
                    {
                        // Check if this is already in use
                        foreach (Meeting m in IntersectingMeetings)
                        {
                            if (m.EquipmentRequests.Contains(e))
                            {
                                output.Add(e);
                            }
                        }
                    }
                }

                return output;
            }
        }

        public HashSet<Meeting> MeetingsUsingOurPortableEquipment
        {
            get
            {
                HashSet<Meeting> output = new HashSet<Meeting>();

                foreach (Equipment e in EquipmentRequests)
                {
                    if (AllEquipment.OnlyOne.Contains(e))
                    {
                        // Check if this is already in use
                        foreach (Meeting m in IntersectingMeetings)
                        {
                            if (m.EquipmentRequests.Contains(e))
                            {
                                output.Add(m);
                                break;
                            }
                        }
                    }
                }

                return output;
            }
        }

        public bool canGoAhead
        {
            get
            {
                foreach(Participant p in this.GuestSpeakers)
                {
                    //if a guest speaker cannot attend, the meeting cannot go ahead
                    if(p.hasGivenAttendance && !p.attending)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public HashSet<Equipment> UnavailableEquipment
        {
            get
            {
                HashSet<Equipment> output = new HashSet<Equipment>();
                foreach(Meeting m in AllMeetings.meetings)
                {
                    //if we're looking at a  different meeting
                    //and it intersects with this one
                    //then we'll check its equipment list
                    if(m != this && this.Intersects(m))
                    {
                        foreach(Equipment equip in this.EquipmentRequests)
                        {
                            //if the other meeting contains this piece of equipment
                            //there is a chance it will not be available
                            if (m.EquipmentRequests.Contains(equip))
                            {
                                if (AllEquipment.OnlyOne.Contains(equip))
                                {
                                    output.Add(equip);
                                }
                            }
                        }
                    }
                    else if(m==this)
                    {
                     //need to check this meetings locations fixed equipmenmt against this meetings requests
                    }
                }
                return output;
            }
        }

        //returns the first potential location
        public Location CurrentLocation = null;

        public Location ProvisionalLocation {
            get
            {
                HashSet<Location> takenLocations = new HashSet<Location>();
                HashSet<Location> unsuitableBecauseNoEquipment = new HashSet<Location>();

                foreach (Meeting m in IntersectingMeetings)
                {
                    takenLocations.Add(m.CurrentLocation);
                }

                if (this.PotentialLocations.Count < 1)
                {
                    return null;
                }
                //default the location on the first one
                Location output = null;
                Dictionary<Location, int> votes = new Dictionary<Location, int>();
                if (this.PotentialLocations.Count > 0)
                {
                    foreach (Location loc in this.PotentialLocations)
                    {
                        if (takenLocations.Contains(loc))
                            continue;

                        if (!votes.ContainsKey(loc))
                            votes.Add(loc, 0);

                        foreach (Participant p in this.Participants)
                        {
                            if (p.status > 0 && p.locationPreferences.Contains(loc))
                            {
                                //Guest speakers preferences have a weight of 1 million on the location of this meeting
                                int voteWeight = p.status == 2 ? 1000000 : p.status == 1 ? 1 : 0;
                                votes[loc] += voteWeight;
                            }
                        }
                    }
                    if (votes.Count > 0)
                    {
                        //set the location to the one with the most votes
                        output = votes.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                    }
                }
                return output;
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

        public List<Meeting> IntersectingMeetings
        {
            get
            {
                List<Meeting> output = new List<Meeting>();

                foreach (Meeting m in AllMeetings.meetings)
                {
                    if (m == this) continue;

                    if (m.Intersects(this))
                        output.Add(m);
                }

                return output;
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
                    //otherwise if their status is 2, make them standard.
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
