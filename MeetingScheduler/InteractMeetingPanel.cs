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
        public InteractMeetingPanel()
        {
            InitializeComponent();
            UpdatePanels(null, null);
        }

        public void UpdatePanels(Meeting m,User impersonating)
        {
            this._meeting = m;
            this._impersonator = impersonating;
            Logging.AddMessage($"Meeting set to {_meeting}");
            editBtn.Enabled = this._meeting!= null && this._meeting.Initiator == impersonating;
            meetingTitleLbl.Text = this._meeting?.Name ?? "No Meeting Selected";
            meetingDescTB.Text = this._meeting?.Details ?? "No description provided...";

            //refresh the displayed panels
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this._meeting != null)
            {
                CreateMeeting cM = new CreateMeeting(this._meeting);
                cM.Show();
            }
        }
    }
}
