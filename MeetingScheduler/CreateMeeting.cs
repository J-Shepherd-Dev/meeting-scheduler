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
        private DateTime? originalTime = null;

        public bool editing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                _isEditing = value;
                newMeetingSaveBtn.Text = _isEditing ? "Done" : "Create";

                cancelBtn.Text = _isEditing ? "Cancel Meeting" : "Cancel";

            }
        }

        private LayoutSuspensionSemaphore participantSemaphore;

        //Disable Close (X) button
        //doing this means that the user must click "Done" or "Cancel meeting"
        //when they are editing a meeting - since changes are actually applied right away
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        public CreateMeeting(User initiator)
        {
            this._thisMeeting = new Meeting(initiator);

            InitializeComponent();
            participantSemaphore = new LayoutSuspensionSemaphore(participantFlowPanel);

            UpdatePanels();
            //ensure all users are displayed in the 'search' dropdown
            userToAddBox.Items.AddRange(AllUsers.Users.ToArray());
            calendarPanel1.editedMeeting = _thisMeeting;
            this.cancelBtn.Text = editing ? "Cancel Meeting" : "Cancel";
        }

        public CreateMeeting(Meeting meeting)
        {
            this._thisMeeting = meeting;

            InitializeComponent();
            participantSemaphore = new LayoutSuspensionSemaphore(participantFlowPanel);

            UpdatePanels();

            // Ensure data on screen matches the meeting
            editing = true;

            newMeetingTitle.Text = meeting.Name;
            newMeetingDetails.Text = meeting.Details;
            numericUpDown1.Value = meeting.Length;
            originalTime = meeting.StartTime;

            userToAddBox.Items.AddRange(AllUsers.Users.ToArray());
            calendarPanel1.editedMeeting = _thisMeeting;
            this.cancelBtn.Text = editing ? "Cancel Meeting" : "Cancel";
        }

        private void newMeetingDetails_TextChanged(object sender, EventArgs e)
        {
            this._thisMeeting.Details = (sender as TextBox).Text;
        }

        private void newMeetingTitle_TextChanged(object sender, EventArgs e)
        {
            this._thisMeeting.Name = (sender as TextBox).Text;
        }
        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            calendarPanel1.Changed += CheckMeetingLength;
            this.UpdatePanels();
        }

        private void CreateMeeting_ResizeBegin(object sender, EventArgs e)
        {
            calendarPanel1.semaphore.AddUser();
        }

        private void CreateMeeting_ResizeEnd(object sender, EventArgs e)
        {
            calendarPanel1.semaphore.RemoveUser();
         }

        private void AddParticipantToPanel(Participant p) {
            ParticipantPanel pPanel = new ParticipantPanel(this._thisMeeting, p,0, this);
            pPanel.Dock = DockStyle.Top;
            pPanel.Width = this.participantFlowPanel.Width - this.participantFlowPanel.Padding.Left - this.participantFlowPanel.Padding.Right;
            this.participantFlowPanel.Controls.Add(pPanel);
        }
        public void DrawParticipantList() {
            using (var handle = participantSemaphore.Acquire())
            {
                this.UpdateParticipantInfoLabel(this._thisMeeting.GuestSpeaker == null ? "" : "The guest speaker is "+this._thisMeeting.GuestSpeaker);
                this.participantFlowPanel.Controls.Clear();

                Logging.AddMessage("There are "+this._thisMeeting.Participants.Count+" participants in the created meeting.");
                foreach(Participant p in this._thisMeeting.Participants) {
                    this.AddParticipantToPanel(p);
                    userToAddBox.Items.Remove(p.user);
                    Logging.AddMessage($"Added participant {p} to panel");
                }
            }
        }

        public void UpdateParticipantInfoLabel(string msg="") {
            this.participantInfoLbl.Visible = (msg == "" || msg == null);
            this.participantInfoLbl.Text = msg;
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
        //updates the CalendarPanel in this form
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
                    if (p.hasGivenAttendance && p.attending && users.Contains(p.user))
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
            // Check to make sure the user hasn't put the meeting in a conflicting position
            List<Meeting> conflicting = _thisMeeting.IntersectingMeetings;
            List<Meeting> lowerImportance = new List<Meeting>();

            foreach (Meeting m in conflicting)
            {
                if (_thisMeeting.ComparePriority(m) < 0)
                {
                    lowerImportance.Add(m);
                }
            }

            if (conflicting.Count > 0)
            {
                // If there is a meeting of higher importance, the meeting cannot occur at this time.
                // Otherwise, offer to move one of the meetings.

                if (lowerImportance.Count < conflicting.Count)
                {
                    DialogResult result = MessageBox.Show($"One of your participants has already said they will attend a meeting of higher importance at this time.\n\nYou can choose to schedule the meeting here anyway, but it is unlikely they will attend.\n\nDo you want to schedule the meeting at this time?", "Meeting conflict", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel)
                        return;
                } else
                {
                    string listOfMeetings = "";
                    foreach (Meeting m in lowerImportance)
                        listOfMeetings += $"- {m}\n";

                    DialogResult result = MessageBox.Show($"One or more of your participants have already said they will attend a meeting of lower importance at this time::\n\n{listOfMeetings}\nYou can choose to move these meetings to make yours easier to attend.\n\nDo you want to move the conflicting meetings?", "Meeting conflict", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        foreach (Meeting m in lowerImportance)
                        {
                            CreateMeeting cM = new CreateMeeting(m);
                            cM.Show();
                        }
                        return;
                    } else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }

            // Update the meeting
            AllMeetings.Update(this._thisMeeting);

            if (editing)
            {
                if (originalTime != _thisMeeting.StartTime)
                    _thisMeeting.HasBeenMoved = true;
                Logging.AddMessage($"Edited meeting {_thisMeeting}");
            }
            else
            {
                Logging.AddMessage($"Created meeting {_thisMeeting}");
            }

            this.Close();
        }

        private void CheckMeetingLength(object sender, EventArgs e)
        {
            using (var handle = calendarPanel1.Suspend())
            {
                DateTime seven_pm = this._thisMeeting.StartTime.Date + new TimeSpan(19, 0, 0);

                if (this._thisMeeting.EndTime > seven_pm)
                {
                    this._thisMeeting.EndTime = seven_pm;

                    numericUpDown1.Value = this._thisMeeting.Length;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (var handle = calendarPanel1.Suspend())
            {
                this._thisMeeting.Length = (int)(sender as NumericUpDown).Value;
                CheckMeetingLength(sender, e);

                //update the calendar panel
                RefreshParticipantMeetings();
            }
        }

        private void CreateMeeting_FormClosing(object sender, FormClosingEventArgs e)
        {
            calendarPanel1.Changed -= CheckMeetingLength;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (this._isEditing)
            {
                //the meeting will only be removed if the user confirms this AND
                // it is already an existing meeting
                DialogResult confirmCancellation = MessageBox.Show($"Are you sure you want to cancel {this._thisMeeting}?", "Cancel Meeting", MessageBoxButtons.YesNo);
                if (confirmCancellation == DialogResult.Yes && AllMeetings.meetings.Contains(this._thisMeeting))
                    {
                        AllMeetings.Remove(this._thisMeeting);
                        this.Close();
                    }
            }
            else
            {
                this.Close();
            }
        }
    }
}
