using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    static class AllUsers
    {
        public static User jack = new User("Jack", "jack");
        public static User mehmet = new User("Mehmet", "mehmet");
        public static User ryan = new User("Ryan");
        public static User john = new User("John","john");
        public static User tom = new User("Tom", "tom");

        public static HashSet<User> Users = new HashSet<User>() {
            jack,
            mehmet,
            ryan,
            john,
            tom
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
