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
        public static Location BigConferenceRoom = new Location("Conference Room",20);
        public static Location OfficeC = new Location("Office C", 4);
        public static Location OfficeD = new Location("Office D",3);
        public static Location OfficeE = new Location("Office E", 2);

        public static List<Location> Locations = new List<Location>(){
            MeetingRoomA,
            MeetingRoomB,
            BigConferenceRoom,
            OfficeC,
            OfficeD,
            OfficeE
};
    }
}
