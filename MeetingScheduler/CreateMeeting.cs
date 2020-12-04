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
    public partial class CreateMeeting : Form
    {
        public Meeting _thisMeeting;
        private bool _isEditing = false;

        public bool editing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                _isEditing = value;
                newMeetingSaveBtn.Text = _isEditing ? "Edit" : "Create";
            }
        }

        public CreateMeeting(User initiator)
        {
            this._thisMeeting = new Meeting(initiator);
            InitializeComponent();
            UpdatePanels();
            //ensure all users are displayed in the 'search' dropdown
            userToAddBox.Items.AddRange(AllUsers.Users.ToArray());
            calendarPanel1.editedMeeting = _thisMeeting;
        }

        public CreateMeeting(Meeting meeting)
        {
            this._thisMeeting = meeting;
            InitializeComponent();
            UpdatePanels();

            // Ensure data on screen matches the meeting
            editing = true;
            newMeetingTitle.Text = meeting.Name;
            newMeetingDetails.Text = meeting.Details;

            userToAddBox.Items.AddRange(AllUsers.Users.ToArray());
            calendarPanel1.editedMeeting = _thisMeeting;
        }

        private void newMeetingDetails_TextChanged(object sender, EventArgs e)
        {
            this._thisMeeting.Details = (sender as TextBox).Text;
        }

        private void newMeetingTitle_TextChanged(object sender, EventArgs e)
        {
            this._thisMeeting.Name = (sender as TextBox).Text;
        }

        private void newMeetingCancelBtn_Click(object sender, EventArgs e)
        {
            Logging.AddMessage($"Cancelled creation of meeting {_thisMeeting}");

            this.Close();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            this.UpdatePanels();
        }

        private void CreateMeeting_ResizeBegin(object sender, EventArgs e)
        {
            calendarPanel1.SuspendLayout();
        }

        private void CreateMeeting_ResizeEnd(object sender, EventArgs e)
        {
            calendarPanel1.ResumeLayout();
         }

        private void AddParticipantToPanel(Participant p) {
            ParticipantPanel pPanel = new ParticipantPanel(this._thisMeeting, p,0, this);
            pPanel.Dock = DockStyle.Top;
            pPanel.Width = this.participantFlowPanel.Width - this.participantFlowPanel.Padding.Left - this.participantFlowPanel.Padding.Right;
            this.participantFlowPanel.Controls.Add(pPanel);
        }
        private void DrawParticipantList() {
            this.participantFlowPanel.SuspendLayout();
            this.participantFlowPanel.Controls.Clear();
            Logging.AddMessage("There are "+this._thisMeeting.Participants.Count+" participants in the created meeting.");
            foreach(Participant p in this._thisMeeting.Participants) {
                this.AddParticipantToPanel(p);
                userToAddBox.Items.Remove(p.user);
                Logging.AddMessage($"Added participant {p} to panel");
            }
            this.participantFlowPanel.ResumeLayout();
        }

        public void AddUserToDropdown(User u) {
            if (!userToAddBox.Items.Contains(u))
            {
                userToAddBox.Items.Add(u);
            }
        }
        public void AddParticipantBtnClick(object sender, EventArgs e)
        {
            if (userToAddBox.SelectedItem != null) {
                Participant p = new Participant((User)userToAddBox.SelectedItem);
                //add this partic0ant to the meeting
                this._thisMeeting.Participants.Add(p);
                //add this participant to the displayed list
                AddParticipantToPanel(p);
                //remove the selected option from the search sinc ethey've been added to the meeting
                userToAddBox.Items.RemoveAt(userToAddBox.SelectedIndex);
                //update the calendar panel
                RefreshParticipantMeetings();
            }
        }

        public void UpdatePanels() {
            this.newMeetingTitle.Text = this._thisMeeting.Name;
            this.newMeetingDetails.Text = this._thisMeeting.Details;
            DrawParticipantList();
            RefreshParticipantMeetings();
        }

        public void RefreshParticipantMeetings()
        {
            List<Meeting> meetings = new List<Meeting>();
            List<User> users = new List<User>();

            // Get users from participants
            foreach (Participant p in _thisMeeting.Participants)
            {
                users.Add(p.user);
            }

            // Find meetings that our participants are in
            foreach (Meeting m in AllMeetings.meetings)
            {
                foreach (Participant p in m.Participants)
                {
                    if (users.Contains(p.user))
                    {
                        meetings.Add(m);
                        break;
                    }
                }
            }

            Logging.AddMessage($"Found {meetings.Count} existing meetings amongst selected participants.");
            calendarPanel1.meetings = meetings.ToArray();
        }

        private void newMeetingSaveBtn_Click(object sender, EventArgs e)
        {
            // Set meeting attributes
            _thisMeeting.Name = newMeetingTitle.Text;
            _thisMeeting.Details = newMeetingDetails.Text;

            // Push meeting if it's newly created
            AllMeetings.Update(this._thisMeeting);

            if (editing)
                Logging.AddMessage($"Edited meeting {_thisMeeting}");
            else
                Logging.AddMessage($"Created meeting {_thisMeeting}");

            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this._thisMeeting.Length = (int)(sender as NumericUpDown).Value;
            if (this._thisMeeting.Time.Hour + this._thisMeeting.Length > 19) {
                //TODO: set this to the correct value, not 1
                this._thisMeeting.Length = 1;
                (sender as NumericUpDown).Value = this._thisMeeting.Length;
            }
            //update the calendar panel
            RefreshParticipantMeetings();
        }
    }
}
