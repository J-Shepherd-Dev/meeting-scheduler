using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public static class AllMeetings
    {
        public static List<Meeting> meetings = new List<Meeting>();
        public static event EventHandler newMeeting;

        public static void Add(Meeting instance)
        {
            meetings.Add(instance);

            // Send event
            newMeeting?.Invoke(null, new EventArgs());
        }
    }
}
