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
        public bool shouldNotifyInitiator = false;
        public Equipment(string name, int capacity = 0,bool notifyInitiator=false)
        {
            this.Name = name;
            this.requiresCapacity = capacity;
            this.shouldNotifyInitiator = false;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
