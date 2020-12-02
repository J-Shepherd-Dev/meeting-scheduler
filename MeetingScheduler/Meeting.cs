using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Meeting
    {
        public string Name = "Meeting";
        public string Details = "";
        public DateTime Time;
        public int Length;  // in hours
        public User Initiator;
        public HashSet<Participant> Participants;

        public Meeting(User initiator) {
            this.Time = System.DateTime.Today;
            this.Length = 1;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }
        public Meeting(User initiator, string name, DateTime time, int length = 1)
        {
            this.Name = name;
            this.Time = time;
            this.Length = length;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
