using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    static class AllUsers
    {
        public static HashSet<User> Users = new HashSet<User>() {
            new User("Jack","jack"),
            new User("Mehmet","mehmet"),
            new User("Ryan"),
            new User("John"),
            new User("Tom","tom")
        };
        public static void Add(User u) {
            if (!AllUsers.Users.Contains(u))
            {
                AllUsers.Users.Add(u);
            }
        }
        public static void Remove(User u) {
            if (AllUsers.Users.Contains(u))
            {
                AllUsers.Users.Remove(u);
            }
        }
        public static bool Contains(User u) {
            return AllUsers.Users.Contains(u);
        }
    }
}
