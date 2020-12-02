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
        public ParticipantPanel(Meeting m, Participant p)
        {
            this.meeting = m;
            this.participant = new Participant("Jack Carey","jack");
            this.nameLbl.Text = this.participant.getName();
            this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(this.participant.ImageName.ToString());
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //remove this participant from the meeting
            this.meeting.Participants.Remove(this.participant);
            this.Dispose();
        }
    }
}
