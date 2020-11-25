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
        public DateTime Time;
        public int Length;  // in hours

        public Meeting(string name, DateTime time, int length = 1)
        {
            this.Name = name;
            this.Time = time;
            this.Length = length;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
