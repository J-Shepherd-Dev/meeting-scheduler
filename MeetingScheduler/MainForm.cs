using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class MainForm : Form
    {
        //other forms
        DevLogForm devForm = new DevLogForm();
        private User _activeUser = null;
        private Meeting _activeMeeting = null;
        public MainForm()
        {
            InitializeComponent();
            // set the drop down options
            impersonationComboBox.DataSource = AllUsers.Users.ToList();
            impersonationComboBox.DisplayMember = "Name";
            this._activeUser = (User)impersonationComboBox.SelectedItem;
            //set up the devForm
            devForm.ShowIcon = false;
            devForm.ShowInTaskbar = true;

            // Assign event handler for new meetings
            AllMeetings.meetingsUpdated += AllMeetings_meetingsUpdated;

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
            funkyDanceParty.Participants.Add(new Participant(AllUsers.mehmet,2,true));
            funkyDanceParty.Participants.Add(new Participant(AllUsers.ryan,0,true));
            funkyDanceParty.Participants.Add(new Participant(AllUsers.tom,1,true));

            //USER STORY 1
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

            Meeting UserStory1AccCrit2 = new Meeting(
            AllUsers.tom,
            "User Story 1 - Acceptance Criteria 2",
            currentWeek + new TimeSpan(1, 12, 00, 0),
            1);
            UserStory1AccCrit2.Details = "User Story 1 - Acceptance Criteria 2";
            Participant us1ac2Jack = new Participant(AllUsers.jack);
            Participant us1ac2Ryan = new Participant(AllUsers.ryan);
            UserStory1AccCrit2.Participants.Add(us1ac2Jack);
            UserStory1AccCrit2.Participants.Add(us1ac2Ryan);

            //USER STORY 2

            //USER STORY 3

            //User STORY 4

            //USER STORY 5
            Meeting NetworkLabMeeting = new Meeting(
                AllUsers.tom,
                "Network Lab Demonstration",
                currentWeek+ new TimeSpan(3,9,0,0),
                9);
            Participant networkLabTom = new Participant(AllUsers.tom, 1, true);
            networkLabTom.locationPreferences.Add(AllLocations.NetworkLab);
            NetworkLabMeeting.Details = "Tom and Ryan use the network lab";
            NetworkLabMeeting.Participants.Add(networkLabTom);
            NetworkLabMeeting.Participants.Add(new Participant(AllUsers.ryan, 1, true));

            Meeting JohnsNetworkLabMeeting = new Meeting(AllUsers.john,
                "Johns Network Lab #1",
                currentWeek + new TimeSpan(3,10,0,0),
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
            AllMeetings.Update(funkyDanceParty);
            AllMeetings.Update(UserStory1AccCrit1);
            AllMeetings.Update(UserStory1AccCrit2);
            AllMeetings.Update(NetworkLabMeeting);
            AllMeetings.Update(JohnsNetworkLabMeeting);
            AllMeetings.Update(JohnsNetworkLabMeeting2);

            Logging.AddMessage("Initialisation complete");
        }

        private void AllMeetings_meetingsUpdated(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            this._activeMeeting = null;

            // Index to select in the initiated meeting list, if applicable
            int? selectIndex = null;

            // Update tabs
            initiatedTabList.Items.Clear();
            invitedTabList.Items.Clear();
            scheduledTabList.Items.Clear();

            foreach (Meeting m in AllMeetings.meetings)
            {
                // If this user initiated this meeting, add it to the initiated list
                if (m.Initiator == _activeUser)
                {
                    // Record the index the meeting is added at.
                    int index = initiatedTabList.Items.Add(m);

                    // If this meeting is also the meeting that was updated
                    if (m == AllMeetings.lastMeeting)
                    {
                        // Set the index to select to be this meeting
                        // This means when a user creates or updates a meeting it will select itself by default
                        selectIndex = index;

                        // Also set it to be the active meeting so it shows in the details pane
                        _activeMeeting = m;
                    }
                }

                foreach (Participant p in m.Participants)
                {
                    if (p.user == _activeUser)
                    {
                        invitedTabList.Items.Add(m);
                        break;
                    }
                }
            }

            if (selectIndex != null)
            {
                // Set us to the "Initiated" tab
                tabControl1.SelectedIndex = 0;

                // Select the current meeting in that list
                // We shouldn't need to null coalesce this but the compiler can't detect we've already checked for null
                initiatedTabList.SelectedIndex = selectIndex ?? 0;
            }

            this.interactMeetingPanel1.UpdatePanels(this._activeMeeting, this._activeUser);
        }

        //this function is called on ResizeEnd
        private void ResizeWindow(object sender, EventArgs e)
        {
            //TODO: resize inner elements, if needed

        }

        public void UpdateDetailsPane(Control control) {
            detailsBox.Controls.Clear();
            control.Dock = DockStyle.Fill;
            detailsBox.Text = control.Name;
            detailsBox.Controls.Add(control);
        }

        private void yourMeetingsTab_Click(object sender, EventArgs e)
        {
        }

        private void detailsBox_Enter(object sender, EventArgs e)
        {
            Logging.AddMessage("Details Entered");
        }

        private void devWindowBtn_Click(object sender, EventArgs e)
        {
            if (devForm.IsDisposed)
                // The last dev form was closed and we need to make a new one
                devForm = new DevLogForm();

            devForm.Show();
            devForm.Activate();
            devForm.TopMost = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl sdr = sender as TabControl;
            Logging.AddMessage("Tab selected: " + sdr.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMeeting cM = new CreateMeeting((User)(impersonationComboBox.SelectedItem));
            cM.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AllMeetings.meetingsUpdated -= AllMeetings_meetingsUpdated;
        }

        private void impersonationComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this._activeUser = (User)(sender as ComboBox).SelectedItem;
            UpdateDisplay();
        }

        private void initiatedTabList_SelectedValueChanged(object sender, EventArgs e)
        {
            this._activeMeeting = (Meeting)(sender as ListBox).SelectedItem;
            this.interactMeetingPanel1.UpdatePanels(this._activeMeeting, this._activeUser);
        }

        private void invitedTabList_SelectedValueChanged(object sender, EventArgs e)
        {
            this._activeMeeting = (Meeting)(sender as ListBox).SelectedItem;
            this.interactMeetingPanel1.UpdatePanels(this._activeMeeting, this._activeUser);
        }

        private void scheduledTabList_SelectedValueChanged(object sender, EventArgs e)
        {
            this._activeMeeting = (Meeting)(sender as ListBox).SelectedItem;
            this.interactMeetingPanel1.UpdatePanels(this._activeMeeting, this._activeUser);
        }

        private void interactMeetingPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
