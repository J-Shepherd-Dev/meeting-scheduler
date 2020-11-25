using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class Slot
    {
        private string name = "Slot";
        private DateTime dateTime;
        private int hour = 0;
        public Slot(string name)
        {
            this.name = name;
            this.dateTime = new DateTime();
            this.hour = this.dateTime.Hour;
        }
        public Slot(DateTime dt) {
            this.dateTime = dt;
            this.hour = this.dateTime.Hour;
        }

        public override string ToString()
        {
            return this.name + " " + this.hour + (this.hour < 12? "am" : "pm") ;
        }
    }
}
