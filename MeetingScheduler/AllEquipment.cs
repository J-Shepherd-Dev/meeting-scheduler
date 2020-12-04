using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public static class AllEquipment
    {
        /*Equipment*/
        public static Equipment Projector = new Equipment("Projector");
        public static Equipment Whiteboard = new Equipment("Whiteboard");
        public static Equipment LaptopRack = new Equipment("Laptop Rack");
        public static Equipment Printer = new Equipment("Printer");
        public static Equipment Computer = new Equipment("Computer");
        public static Equipment WheelchairAccess = new Equipment("Wheelchair Access");

        /*Humans*/
        public static Equipment Assisitant = new Equipment("Assistant", 1);
        public static Equipment Translator = new Equipment("Translator", 1);

        /*All*/
        public static List<Equipment> Equipment = new List<Equipment>(){
            Projector,
            Whiteboard,
            LaptopRack,
            Printer,
            Computer,
            WheelchairAccess,
            Assisitant,
            Translator
        };
    }
}
