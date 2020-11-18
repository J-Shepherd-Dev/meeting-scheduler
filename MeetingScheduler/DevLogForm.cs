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
        public DevLogForm()
        {
            InitializeComponent();

            Logging.newMessage += Logging_newMessage;
        }

        public void UpdateMessages() {
            devLogFlowPanel.SuspendLayout();
            devLogFlowPanel.Controls.Clear();
            foreach (String message in Logging.messageBuffer) {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = message;
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Black;
                lbl.Visible = true;
                devLogFlowPanel.Controls.Add(lbl);
            }
            devLogFlowPanel.ResumeLayout();
        }

        private void Logging_newMessage(object sender, EventArgs e)
        {
            UpdateMessages();
        }

        private void DevLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logging.newMessage -= Logging_newMessage;
        }
    }
}
