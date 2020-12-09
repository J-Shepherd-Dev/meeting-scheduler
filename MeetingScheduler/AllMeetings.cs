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

        public static void Reset()
        {
            // Reset meetings
            lastMeeting = null;
            meetings.Clear();

            // Create Mehmet's funky dance party
            TimeSpan untilBeginning = new TimeSpan((int)DateTime.Today.DayOfWeek, 0, 0, 0);

            DateTime currentWeek = (DateTime.Today - untilBeginning).Date;

            /*
             * Add the meetings we need for user stories
             */

            //DANCE PARTY
            Meeting funkyDanceParty = new Meeting(
                AllUsers.tom,
                "Mehmet's Funky Dance Party",
                currentWeek + new TimeSpan(
                    2,  // Tuesday
                    12, 0, 0  // At 12 pm
                ),
                2
            );
            //add a description
            funkyDanceParty.Details = "Mehmet's holding his annual funky dance party! Don your best 60's outfit then get ready to dance and feel a rhythm through a mixture of soul, jazz, and R&B!";
            // Everyone is invited to Mehmet's funky dance party
            funkyDanceParty.Participants.Add(new Participant(AllUsers.jack));
            funkyDanceParty.Participants.Add(new Participant(AllUsers.john));
            //Tom, Ryan, and Mehmet are all attending with varying statuses 
            funkyDanceParty.Participants.Add(new Participant(AllUsers.mehmet, 2, true));
            funkyDanceParty.Participants.Add(new Participant(AllUsers.ryan, 0, true));
            funkyDanceParty.Participants.Add(new Participant(AllUsers.tom, 1, true));

            // -- USER STORY 1 --
            // Acceptance Criteria 1
            Meeting UserStory1AccCrit1 = new Meeting(
                AllUsers.jack,
                "Meeting for Ryan",
                currentWeek + new TimeSpan(1, 11, 0, 0),
                1
            );
            UserStory1AccCrit1.Details = "Jack and Ryan chit-chat.";
            Participant us1ac1Jack = new Participant(AllUsers.jack);
            Participant us1ac1Ryan = new Participant(AllUsers.ryan);
            UserStory1AccCrit1.Participants.Add(us1ac1Jack);
            UserStory1AccCrit1.Participants.Add(us1ac1Ryan);

            // Acceptance Criteria 2
            Meeting UserStory1AccCrit2 = new Meeting(
                AllUsers.tom,
                "An Analysis of Lamb Bananas",
                currentWeek + new TimeSpan(1, 12, 00, 0),
                1
            );
            UserStory1AccCrit2.Details = "User Story 1 - Acceptance Criteria 2";
            Participant us1ac2Jack = new Participant(AllUsers.jack);
            Participant us1ac2Ryan = new Participant(AllUsers.ryan);
            UserStory1AccCrit2.Participants.Add(us1ac2Jack);
            UserStory1AccCrit2.Participants.Add(us1ac2Ryan);

            // Acceptance Criteria 3
            Meeting UserStory1AccCrit3 = new Meeting(
                AllUsers.tom,
                "Laptop Rack Inspection",
                currentWeek + new TimeSpan(2, 9, 0, 0),
                9
            );
            Participant us1ac3John = new Participant(AllUsers.john, 1, true);
            Participant us1ac3Ryan = new Participant(AllUsers.ryan, 1);
            UserStory1AccCrit3.Details = "John will be checking the laptop rack for inspections";
            UserStory1AccCrit3.Participants.Add(us1ac3John);
            UserStory1AccCrit3.Participants.Add(us1ac3Ryan);

            // -- USER STORY 2 --

            // -- USER STORY 3 --

            // -- User STORY 4 --

            // -- USER STORY 5 --
            Meeting NetworkLabMeeting = new Meeting(
                AllUsers.tom,
                "Network Lab Demonstration",
                currentWeek + new TimeSpan(3, 9, 0, 0),
                9);
            Participant networkLabTom = new Participant(AllUsers.tom, 1, true);
            networkLabTom.locationPreferences.Add(AllLocations.NetworkLab);
            NetworkLabMeeting.Details = "Tom and Ryan use the network lab";
            NetworkLabMeeting.Participants.Add(networkLabTom);
            NetworkLabMeeting.Participants.Add(new Participant(AllUsers.ryan, 1, true));

            Meeting JohnsNetworkLabMeeting = new Meeting(AllUsers.john,
                "Johns Network Lab #1",
                currentWeek + new TimeSpan(3, 10, 0, 0),
                1);
            Participant networkJohn = new Participant(AllUsers.john, 1, true);
            networkJohn.locationPreferences.Add(AllLocations.NetworkLab);
            JohnsNetworkLabMeeting.Participants.Add(networkJohn);
            JohnsNetworkLabMeeting.Participants.Add(new Participant(AllUsers.jack, 0, true));
            JohnsNetworkLabMeeting.Participants.Add(new Participant(AllUsers.mehmet, 0, true));

            Meeting JohnsNetworkLabMeeting2 = new Meeting(AllUsers.john,
                "Johns Network Lab #2",
                currentWeek + new TimeSpan(4, 10, 0, 0),
                1);
            Participant networkJohn2 = new Participant(AllUsers.john, 1, true);
            networkJohn.locationPreferences.Add(AllLocations.NetworkLab);
            JohnsNetworkLabMeeting.Participants.Add(networkJohn2);
            JohnsNetworkLabMeeting.Participants.Add(new Participant(AllUsers.jack, 0, true));
            JohnsNetworkLabMeeting.Participants.Add(new Participant(AllUsers.mehmet, 0, true));

            /*
             * Save the meetings in the static class
             */
            meetings.Add(funkyDanceParty);
            meetings.Add(UserStory1AccCrit1);
            meetings.Add(UserStory1AccCrit2);
            meetings.Add(NetworkLabMeeting);
            meetings.Add(JohnsNetworkLabMeeting);
            meetings.Add(JohnsNetworkLabMeeting2);
            meetings.Add(UserStory1AccCrit3);
            
            //Send event
            meetingsUpdated?.Invoke(null, new EventArgs());
        }
    }
}
