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
        private CreateMeeting cMForm;
        public SelectPartcipantsWindow(CreateMeeting createMeetingCaller)
        {
            this.cMForm = createMeetingCaller;
            InitializeComponent();
            this.textBox1.Text = "You're editing participants for '"+this.cMForm._thisMeeting.Name+"'.";
            flowLayoutPanel1.SuspendLayout();
            //add existing participant objects
            for(int i=0;i< createMeetingCaller._thisMeeting.Participants.Count; ++i) {
                Participant p = this.cMForm._thisMeeting.Participants.ElementAt(i);
                ParticipantPanel pPanel = new ParticipantPanel(
                    ref this.cMForm._thisMeeting,
                    ref p,
                    1);
                pPanel.Dock = DockStyle.Top;
                pPanel.Width = this.flowLayoutPanel1.Width - this.flowLayoutPanel1.Padding.Left - this.flowLayoutPanel1.Padding.Right;
                this.flowLayoutPanel1.Controls.Add(pPanel);
            }
            //for all users
            foreach (User u in AllUsers.Users) {
                bool isFound = false;
                //if they are already in the participant list
                foreach (Participant p in createMeetingCaller._thisMeeting.Participants) {
                    //don't add them again;
                    if (p.user == u) {
                        isFound = true;
                        break;
                    }
                }
                //if the user isn't found, add their panel
                if (!isFound)
                {
                    Participant p = new Participant(u);
                    //set up the panel in add mode
                    ParticipantPanel pPanel = new ParticipantPanel(ref this.cMForm._thisMeeting, ref p, 1)
                    {
                        Dock = DockStyle.Top,
                        AutoSize = true,
                        Visible = true,
                        Width = this.flowLayoutPanel1.Width - this.flowLayoutPanel1.Padding.Left - this.flowLayoutPanel1.Padding.Right
                    };
                    this.flowLayoutPanel1.Controls.Add(pPanel);
                }
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.cMForm.UpdatePanels();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectPartcipantsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cMForm.UpdatePanels();
        }
    }
}
