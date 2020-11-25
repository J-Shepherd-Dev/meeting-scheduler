using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Participant
    {
        private User user;
        Participant(User user) {
            this.user = user;
        }

        public string getName() { return this.user.getName(); }
    }
}
