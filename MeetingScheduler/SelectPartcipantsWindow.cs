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
    public partial class SelectPartcipantsWindow : Form
    {
        private Meeting meeting;
        private CreateMeeting cMForm;
        public SelectPartcipantsWindow(CreateMeeting createMeetingCaller)
        {
            this.cMForm = createMeetingCaller;
            this.meeting = createMeetingCaller._thisMeeting;
            InitializeComponent();
            foreach (User u in AllUsers.Users) {
                Participant p = new Participant(u);
                //set up the panel in add mode
                ParticipantPanel pPanel = new ParticipantPanel(meeting,p,1);
                pPanel.Dock = DockStyle.Top;
                pPanel.Width = this.flowLayoutPanel1.Width - this.flowLayoutPanel1.Padding.Left - this.flowLayoutPanel1.Padding.Right;
                this.flowLayoutPanel1.Controls.Add(pPanel);
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
