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

        public Meeting Meeting
        {
            get
            {
                return _meeting;
            }
            set
            {
                //set the private attribute to the 'value' keyword which is the object passed to this setter
                _meeting = value;
                Logging.AddMessage($"Meeting set to {_meeting}");
                UpdatePanels();
            }
        }
        public InteractMeetingPanel()
        {
            InitializeComponent();
            UpdatePanels();
        }

        private void UpdatePanels()
        {
            editBtn.Enabled = this.Meeting!= null;

            //refresh the displayed panels
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (Meeting != null)
            {
                CreateMeeting cM = new CreateMeeting(this.Meeting);
                cM.Show();
            }
        }
    }
}
