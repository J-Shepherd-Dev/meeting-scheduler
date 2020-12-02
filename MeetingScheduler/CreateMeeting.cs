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
        public CreateMeeting(Meeting m)
        {
            this._thisMeeting = m;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newMeetingInvitees_Enter(object sender, EventArgs e)
        {

        }

        private void newMeetingCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {

        }

        private void CreateMeeting_ResizeBegin(object sender, EventArgs e)
        {
            calendarPanel1.SuspendLayout();
        }

        private void CreateMeeting_ResizeEnd(object sender, EventArgs e)
        {
            calendarPanel1.ResumeLayout();
    

        private void addParticipantButton_Click(object sender, EventArgs e)
        {
                this._thisMeeting.Participants.Add(new Participant("Jack","jack"));
        }
    }
}
