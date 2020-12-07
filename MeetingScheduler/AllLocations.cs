using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class AllLocations
    {
        public static Location MeetingRoomA = new Location("Meeting Room A",5);
        public static Location MeetingRoomB = new Location("Meeting Room B",5);
        public static Location BigConferenceRoom = new Location("Conference Room",30);
        public static Location OfficeC = new Location("Office C", 4);
        public static Location OfficeD = new Location("Office D",3);
        public static Location OfficeE = new Location("Office E", 2);
        public static Location NetworkLab = new Location("Network Lab",20);

        public static List<Location> Locations = new List<Location>(){
            MeetingRoomA,
            MeetingRoomB,
            BigConferenceRoom,
            OfficeC,
            OfficeD,
            OfficeE,
            NetworkLab
        };

        //using this constructor ensures we can add fixed equipment to each Location
        public AllLocations()
        {
            MeetingRoomA.fixedEquipment.Add(AllEquipment.WheelchairAccess);
            MeetingRoomA.fixedEquipment.Add(AllEquipment.Whiteboard);
            MeetingRoomA.fixedEquipment.Add(AllEquipment.Projector);

            MeetingRoomB.fixedEquipment.Add(AllEquipment.LaptopRack);
            MeetingRoomB.fixedEquipment.Add(AllEquipment.Computer);
            MeetingRoomB.fixedEquipment.Add(AllEquipment.Printer);

            BigConferenceRoom.fixedEquipment.Add(AllEquipment.Computer);
            BigConferenceRoom.fixedEquipment.Add(AllEquipment.LaptopRack);
            BigConferenceRoom.fixedEquipment.Add(AllEquipment.Printer);
            BigConferenceRoom.fixedEquipment.Add(AllEquipment.Projector);
            BigConferenceRoom.fixedEquipment.Add(AllEquipment.WheelchairAccess);
            BigConferenceRoom.fixedEquipment.Add(AllEquipment.Whiteboard);

            OfficeC.fixedEquipment.Add(AllEquipment.WheelchairAccess);
            OfficeC.fixedEquipment.Add(AllEquipment.Printer);
            OfficeC.fixedEquipment.Add(AllEquipment.Computer);

            OfficeD.fixedEquipment.Add(AllEquipment.Printer);
            OfficeD.fixedEquipment.Add(AllEquipment.Computer);
            OfficeD.fixedEquipment.Add(AllEquipment.Whiteboard);

            OfficeE.fixedEquipment.Add(AllEquipment.Printer);
            OfficeE.fixedEquipment.Add(AllEquipment.Computer);
            OfficeE.fixedEquipment.Add(AllEquipment.Whiteboard);

            NetworkLab.fixedEquipment.Add(AllEquipment.Computer);
            NetworkLab.fixedEquipment.Add(AllEquipment.LaptopRack);
            NetworkLab.fixedEquipment.Add(AllEquipment.Printer);
            NetworkLab.fixedEquipment.Add(AllEquipment.Projector);
            NetworkLab.fixedEquipment.Add(AllEquipment.WheelchairAccess);
            NetworkLab.fixedEquipment.Add(AllEquipment.Whiteboard);
        }
    }
}
