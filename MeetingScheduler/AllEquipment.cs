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
        public static Equipment Printer = new Equipment("Printer");
        public static Equipment Computer = new Equipment("Computer");
        public static Equipment WheelchairAccess = new Equipment("Wheelchair Access");

        /* Always Mobile */
        public static Equipment LaptopRack = new Equipment("Laptop Rack",0,true);
        public static Equipment PrintOuts = new Equipment("Print-outs",0,true);
        public static Equipment HighContrastSlides = new Equipment("High Contrast Slides",0,true);

        /*Humans*/
        public static Equipment Assisstant = new Equipment("Assistant", 1);
        public static Equipment Translator = new Equipment("Translator", 1);

        /*All*/
        public static List<Equipment> Equipment = new List<Equipment>(){
            Projector,
            Whiteboard,
            LaptopRack,
            Printer,
            Computer,
            PrintOuts,
            HighContrastSlides,
            WheelchairAccess,
            Assisstant,
            Translator
        };
        /* Items in this list only exist once */
        public static List<Equipment> OnlyOne = new List<Equipment>()
        {
            LaptopRack
        };

        /* We can check against this list to potentially alert the user in the case of conflicts*/
        public static List<Equipment> UnlimitedInventory = new List<Equipment>() {
            Assisstant,
            Translator,
            PrintOuts,
            HighContrastSlides
        };

    }
}
