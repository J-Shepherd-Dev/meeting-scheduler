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
        public static Meeting lastMeeting = null;
        public static event EventHandler meetingsUpdated;


        public static void Update(Meeting instance)
        {
            if (!meetings.Contains(instance))
                meetings.Add(instance);

            lastMeeting = instance;

            // Send event
            meetingsUpdated?.Invoke(null, new EventArgs());
        }
    }
}
