using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Location
    {
        public string Name = "Location";
        public int capacity = 1;
        public List<Equipment> fixedEquipment = new List<Equipment>();
        public bool isWheelChairAccessible {
            get {
                return fixedEquipment.Contains(AllEquipment.WheelchairAccess);
            }
        }
        public Location(string name)
        {
            this.Name = name;
        }
        public Location(string name, int capacity) {
            this.Name = name;
            if (capacity >= 1)
            {
                this.capacity = capacity;
            }
        }
        public Location(string name, int capacity, List<Equipment> fixedEquipment)
        {
            this.Name = name;
            if (capacity >= 1)
            {
                this.capacity = capacity;
            }
            this.fixedEquipment = fixedEquipment;
        }

        public bool canAccomodateMeeting(Meeting m)
        {
            if (this.capacity < m.CapacityNeeded)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
