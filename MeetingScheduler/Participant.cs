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
        public List<Equipment> equipmentRequests = new List<Equipment>();
        public List<Location> locationPreferences = new List<Location>();
        //0 = ordinary
        //1 = important
        //2 = guest speaker
        public int status = 0;
        public bool attending = false;
        public bool hasGivenAttendance = false;

        public bool Attendance { 
            get {
                return hasGivenAttendance && attending;
                    }
            set {
                this.hasGivenAttendance = true;
                this.attending = value;
            }
        }
        public Participant(User u,int status=0) {
            this.user = u;
            this.status = status;
        }

        public Participant(User u, int status, bool attending)
        {
            this.user = u;
            this.status = status;
            this.Attendance = attending;
        }

        public override string ToString()
        {
            return this.user.ToString();
        }

    }
}
