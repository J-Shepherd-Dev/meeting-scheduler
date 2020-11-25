using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class User
    {
        private string Name = "User";
        private string imgPath = "";
        public User(string name) {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public string getName() {
            return this.Name;
        }
    }
    
}
