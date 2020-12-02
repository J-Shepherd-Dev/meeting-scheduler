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

        private void _basicConstructor(ref Meeting m,ref Participant p) {
            this.meeting = m;
            this.participant = p;
            InitializeComponent();
            this.nameLbl.Text = p.user.getName();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //try to set the persons image, if this fails then the background image will be used by default
            try
            {
                this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(p.user.ImageName.ToString());
                if (this.meeting.Name.ToLower().Contains("funky") && this.participant.user.ImageName=="mehmet") {
                    this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("funky");
                }
            }
            catch (Exception e) {
                Logging.AddMessage(e.Message);
            }
        }
        public ParticipantPanel(ref Meeting m, ref Participant p,int mode=0)
        {
            /*Modes:
             * 0 = initiator (default)
             * 1 = adding to meeting (instead of selecting role and removing)
             * 2 = non initiator (hide controls);
             * */
            this._basicConstructor(ref m, ref p);
            this.mode = mode;
            //if this panel is being created in view of a user who is not the initiator, hide edit options
            if (mode!=0)
            {
                this.roleBox.Visible = false;
                this.roleBox.Enabled = false;
                if (mode == 1) {
                    this.removeBtn.Text = this.meeting.Participants.Contains(p) ? "Remove" : "Add";
                }
                //if we're also not in 'add' mode, hide the button
                if (mode == 2) {
                    this.removeBtn.Enabled = false;
                    this.removeBtn.Visible = false;
                }
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
            }else if (this.mode == 1) {
                if (this.meeting.Participants.Contains(this.participant)) {
                    this.meeting.Participants.Remove(this.participant);
                    this.removeBtn.Text = "Add";
                } else {
                    this.meeting.Participants.Add(this.participant);
                    this.removeBtn.Text = "Remove";
                }
            }
        }
    }
}
