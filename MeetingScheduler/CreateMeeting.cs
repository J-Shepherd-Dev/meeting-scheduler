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
        private Meeting _thisMeeting;
        SelectPartcipantsWindow sPW;
        public CreateMeeting(User initiator)
        {
            this._thisMeeting = new Meeting(initiator);
            this.sPW = new SelectPartcipantsWindow(this._thisMeeting);
            InitializeComponent();

            calendarPanel1.editedMeeting = _thisMeeting;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newMeetingInvitees_Enter(object sender, EventArgs e)
        {

        }

        private void newMeetingCancelBtn_Click(object sender, EventArgs e)
        {
            Logging.AddMessage($"Cancelled creation of meeting {_thisMeeting}");

            this.Close();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            this.DrawParticipants();
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
            ParticipantPanel pPanel = new ParticipantPanel(this._thisMeeting, p);
            pPanel.Dock = DockStyle.Top;
            pPanel.Width = this.participantFlowPanel.Width - this.participantFlowPanel.Padding.Left - this.participantFlowPanel.Padding.Right;
            this.participantFlowPanel.Controls.Add(pPanel);
        }
        private void DrawParticipants() {
            this.participantFlowPanel.SuspendLayout();
            this.participantFlowPanel.Controls.Clear();

            foreach(Participant p in this._thisMeeting.Participants) {
                this.AddParticipantToPanel(p);
                Logging.AddMessage($"Added participant {p} to panel");
            }

            this.participantFlowPanel.ResumeLayout();
        }
        public void AddParticipantButton_Click(object sender, EventArgs e)
        {
            sPW.Show();
            Participant p = new Participant(AllUsers.jack);

            // This is temporary but somewhere when participants are added we need to refresh the meetings for CalendarPanel
            this._thisMeeting.Participants.Add(p);
            RefreshParticipantMeetings();

            this.AddParticipantToPanel(p);
        }

        private void RefreshParticipantMeetings()
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

            // Push meeting
            AllMeetings.Add(_thisMeeting);

            Logging.AddMessage($"Created meeting {_thisMeeting}");

            this.Close();
        }
    }
}
