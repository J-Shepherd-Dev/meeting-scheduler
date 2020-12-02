﻿using System;
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
        private CreateMeeting cMCaller;

        private void _basicConstructor(Meeting m,Participant p,int mode) {
            this.meeting = m;
            this.participant = p;
            InitializeComponent();
            this.nameLbl.Text = p.user.getName();
            this.mode = mode;
            //if this panel is being created in view of a user who is not the initiator, hide edit options
            if (mode != 0)
            {
                this.roleBox.Visible = false;
                this.roleBox.Enabled = false;
                this.removeBtn.Enabled = false;
                this.removeBtn.Visible = false;
            }
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
        public ParticipantPanel(Meeting m, Participant p, int mode = 0,CreateMeeting cMCaller=null)
        {
            /*Modes:
             * 0 = initiator (default)
             * 1 = adding to meeting (instead of selecting role and removing)
             * 2 = non initiator (hide controls);
             * */
            this._basicConstructor(m, p, mode);
            this.cMCaller = cMCaller;
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.participant.status = (sender as ComboBox).SelectedIndex;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.mode == 0)
            {
                this.meeting.Participants.Remove(this.participant);
                this.Parent.Controls.Remove(this);
                if (this.cMCaller!=null){
                    this.cMCaller.RefreshParticipantMeetings();
                    this.cMCaller.AddUserToDropdown(this.participant.user);
                }
            }
        }
    }
}
