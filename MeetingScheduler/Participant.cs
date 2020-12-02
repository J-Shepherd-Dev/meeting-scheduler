using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Participant : User
    {
        public Dictionary<String, Equipment> dTest = new Dictionary<string, Equipment>();
        //0 = ordinary
        //1 = important
        //2 = guest speaker
        public int status = 0;
        public Participant(string name) : base(name) {}
        public Participant(string name, string imageName) : base(name,imageName){}
        public Participant(User u) : base(u.Name, u.ImageName) { }

    }
}
