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
    public partial class ParticipantPanel : UserControl
    {
        private Meeting meeting;
        private Participant participant;
        private int mode = 0;

        private void _basicConstructor(Meeting m,Participant p) {
            this.meeting = m;
            this.participant = p;
            InitializeComponent();
            this.nameLbl.Text = this.participant.getName();
            //try to set the persons image, if this fails then the background image will be used by default
            try
            {
                this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(this.participant.ImageName.ToString());
            }
            catch (Exception e) {
                Logging.AddMessage(e.Message);
            }
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public ParticipantPanel(Meeting m, Participant p)
        {
            this._basicConstructor(m,p);
            this.tableLayoutPanel1.ColumnCount = 4;
        }
        public ParticipantPanel(Meeting m, Participant p,int mode=0)
        {
            /*Modes:
             * 0 = initiator (default)
             * 1 = adding to meeting (instead of selecting role and removing)
             * 2 = non initiator (hide controls);
             * */
            this._basicConstructor(m, p);
            //if this panel is being created in view of a user who is not the initiator, hide edit options
            if (mode!=0)
            {
                this.roleBox.Visible = false;
                this.roleBox.Enabled = false;
                //if we're also not in 'add' mode, hide the button
                if (mode == 2) {
                    this.removeBtn.Enabled = false;
                    this.removeBtn.Visible = false;
                }
            }
            //if this panel is in 'add mode', change the button appearance
            if (mode == 1) {
                this.removeBtn.Text = "Add";
            }
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.mode == 0)
            {
                this.meeting.Participants.Remove(this.participant);
                this.Parent.Controls.Remove(this);
            }
            if (this.mode == 1) {
                if (this.meeting.Participants.Contains(this.participant)) {
                    this.meeting.Participants.Remove(this.participant);
                } else {
                    this.meeting.Participants.Add(this.participant);
                }
            }
        }
    }
}
