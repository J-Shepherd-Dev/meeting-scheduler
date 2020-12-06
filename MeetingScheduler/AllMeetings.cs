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

        public static void Remove(Meeting instance)
        {
            if (meetings.Contains(instance))
            {
                meetings.Remove(instance);
            }
            //reset the last meeting, since we've removed this one
            lastMeeting = null;
            //Send event
            meetingsUpdated?.Invoke(null, new EventArgs());
        }
    }
}
