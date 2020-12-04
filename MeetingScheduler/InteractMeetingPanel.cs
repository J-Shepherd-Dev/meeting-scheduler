using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class InteractMeetingPanel : UserControl
    {
        private Meeting _meeting;
        private User _impersonator;
        private Participant _participant;  // Participant version of _impersonator

        public InteractMeetingPanel()
        {
            InitializeComponent();
            UpdatePanels(null, null);
        }

        public void UpdatePanels(Meeting m, User impersonating)
        {
            this._meeting = m;
            this._impersonator = impersonating;
            this._participant = this._meeting?.GetParticipant(impersonating);
           
            Logging.AddMessage($"Meeting set to {_meeting}");

            // Update visibility based on user access and stance
            editBtn.Enabled = this._meeting != null && this._meeting.Initiator == impersonating;
            attendNoBtn.Visible = attendYesBtn.Visible = attendLabel.Visible = (_participant != null);

            if (_participant != null) {
                // If we've registered our attendance
                attendYesBtn.BackColor = (_participant.hasGivenAttendance && !_participant.attending) ? Color.DarkGreen : Color.PaleGreen;
                attendNoBtn.BackColor = (_participant.hasGivenAttendance && _participant.attending) ? Color.DarkRed : Color.FromArgb(255, 192, 192);
            }

            // Update text attributes
            meetingTitleLbl.Text = this._meeting?.Name ?? "No Meeting Selected";
            meetingDescTB.Text = this._meeting?.Details ?? "No description provided...";

            // Show the participants for this meeting in the flow panel
            participantFlowPanel.Controls.Clear();

            if (this._meeting != null && this._meeting.Participants.Count > 0)
            {
                foreach (Participant p in this._meeting.Participants)
                {
                    //generic changes such as updating the participant list panel (bit on the right)
                    ParticipantPanel pPanel = new ParticipantPanel(this._meeting, p);
                    participantFlowPanel.Controls.Add(pPanel);
                    //participant specific changes:
                    //such as location and equipment requests made by this particopant
                    if (this._impersonator == p.user) {
                        //if this user is not important, hide the location choices
                        this.locationGB.Visible = p.status != 0;
                    }
                    //and attendance yes/no given by this partipant

                }
            }
           
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this._meeting != null)
            {
                CreateMeeting cM = new CreateMeeting(this._meeting);
                cM.Show();
            }
        }

        private void attendYesBtn_Click(object sender, EventArgs e)
        {
            if (_participant != null)
            {
                _participant.hasGivenAttendance = true;
                _participant.attending = true;

                UpdatePanels(this._meeting, this._impersonator);
            }
        }

        private void attendNoBtn_Click(object sender, EventArgs e)
        {
            if (_participant != null)
            {
                _participant.hasGivenAttendance = true;
                _participant.attending = false;

                UpdatePanels(this._meeting, this._impersonator);
            }
        }
    }
}
