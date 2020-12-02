using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Equipment
    {
        public string Name = "Equipment";
        //if the piece of 'equipment' is actually a person, they will require extra capacity in the room
        public int requiresCapacity = 0;
        public Equipment(string name)
        {
            this.Name = name;
        }

        public Equipment(string name, int capacity) {
            this.Name = name;
            if (capacity>0) {
                this.requiresCapacity = capacity;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
