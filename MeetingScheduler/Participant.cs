using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Participant
    {
        public User user;
        public Dictionary<String, Equipment> dTest = new Dictionary<string, Equipment>();
        //0 = ordinary
        //1 = important
        //2 = guest speaker
        public int status = 0;
        public bool attending = false;
        public bool hasGivenAttendance = false;
        public Participant(User u) {
            this.user = u;
        }

    }
}
