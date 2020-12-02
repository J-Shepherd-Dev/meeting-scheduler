﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    public class Meeting
    {
        public string Name = "Default Meeting";
        public string Details = "A meeting is happening";
        public DateTime Time;
        public int Length;  // in hours
        public User Initiator;
        public HashSet<Participant> Participants;

        public Meeting(User initiator) {
            this.Time = System.DateTime.Today + new TimeSpan(8, 0, 0);
            this.Length = 1;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }
        public Meeting(User initiator, string name, DateTime time, int length = 1)
        {
            this.Name = name;
            this.Time = time;
            this.Length = length;
            this.Initiator = initiator;
            this.Participants = new HashSet<Participant>();
        }

        public bool ContainsUser(User u) {
            if(this.Participants.Count==0) return false;
            foreach (Participant p in this.Participants) {
                if (p.user == u) {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
