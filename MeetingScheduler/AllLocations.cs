using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public static class AllLocations
    {
        public static Location MeetingRoomA = new Location(
            "Meeting Room A", 5,
            new List<Equipment>() { AllEquipment.WheelchairAccess, AllEquipment.Whiteboard, AllEquipment.Projector }
        );
        public static Location MeetingRoomB = new Location(
            "Meeting Room B", 5,
            new List<Equipment> () { AllEquipment.LaptopRack, AllEquipment.Computer, AllEquipment.Printer }
        );
        public static Location BigConferenceRoom = new Location(
            "Conference Room", 30,
            new List<Equipment> () { AllEquipment.Computer, AllEquipment.LaptopRack, AllEquipment.Printer, AllEquipment.Projector, AllEquipment.WheelchairAccess, AllEquipment.Whiteboard }
        );
        public static Location OfficeC = new Location(
            "Office C", 4,
            new List<Equipment> () { AllEquipment.WheelchairAccess, AllEquipment.Printer, AllEquipment.Computer }
        );
        public static Location OfficeD = new Location(
            "Office D", 3,
            new List<Equipment> () { AllEquipment.Printer, AllEquipment.Computer, AllEquipment.Whiteboard }
        );
        public static Location OfficeE = new Location(
            "Office E", 2,
            new List<Equipment> () { AllEquipment.Printer, AllEquipment.Computer, AllEquipment.Whiteboard }
        );
        public static Location NetworkLab = new Location(
            "Network Lab", 20,
            new List<Equipment> () { AllEquipment.Computer, AllEquipment.LaptopRack, AllEquipment.Printer, AllEquipment.Projector, AllEquipment.WheelchairAccess, AllEquipment.Whiteboard }
        );

        public static List<Location> Locations = new List<Location>(){
            MeetingRoomA,
            MeetingRoomB,
            BigConferenceRoom,
            OfficeC,
            OfficeD,
            OfficeE,
            NetworkLab
        };
    }
}
