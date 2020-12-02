using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class User
    {
        public string Name = "User";
        //the users profile image
        public string ImageName = "";
        public User(string name) {
            this.Name = name;
        }
        public User(string name,string imageName)
        {
            this.Name = name=="" ? "User" : name;
            this.ImageName = imageName=="" ? "" : imageName;
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
