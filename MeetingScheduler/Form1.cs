﻿using System;
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
    public partial class MainForm : Form
    {
        //other forms
        DevLogForm devForm = new DevLogForm();
        public MainForm()
        {
            InitializeComponent();
            // set the drop down options
            impersonationComboBox.DataSource = AllUsers.Users.ToList();
            impersonationComboBox.DisplayMember = "Name";
            //set up the devForm
            devForm.ShowIcon = false;
            devForm.ShowInTaskbar = true;
            Logging.AddMessage("Initialisation complete");
        }

        //this function is called on ResizeEnd
        private void ResizeWindow(object sender, EventArgs e)
        {
            //TODO: resize inner elements, if needed

        }

        public void UpdateDetailsPane(Control control) {
            detailsBox.Controls.Clear();
            control.Dock = DockStyle.Fill;
            detailsBox.Text = control.Name;
            detailsBox.Controls.Add(control);
        }

        private void yourMeetingsTab_Click(object sender, EventArgs e)
        {
        }

        private void detailsBox_Enter(object sender, EventArgs e)
        {
            Logging.AddMessage("Details Entered");
        }

        private void devWindowBtn_Click(object sender, EventArgs e)
        {
            if (devForm.IsDisposed)
                // The last dev form was closed and we need to make a new one
                devForm = new DevLogForm();

            devForm.Show();
            devForm.Activate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl sdr = sender as TabControl;
            Logging.AddMessage("Tab selected: " + sdr.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meeting m = new Meeting();
            CreateMeeting cM = new CreateMeeting(m);
            cM.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
