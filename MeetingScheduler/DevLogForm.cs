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
    public partial class DevLogForm : Form
    {
        List<String> messages = new List<String>();
        public DevLogForm()
        {
            InitializeComponent();
        }
        public void AddMessage(String msg) {
            messages.Add(msg);
            //if there are now more than 20 messages
            if (messages.Count > 20) {
                //remove the one at the top
                messages.RemoveAt(0);
            }
            devLogFlowPanel.SuspendLayout();
            devLogFlowPanel.Controls.Clear();
            foreach (String message in messages) {
                Label lbl = new Label();
                lbl.Text = message;
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Black;
                lbl.Visible = true;
                devLogFlowPanel.Controls.Add(lbl);
            }
            devLogFlowPanel.ResumeLayout();
        }
    }
}
