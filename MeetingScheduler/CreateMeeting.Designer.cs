using System;

namespace MeetingScheduler
{
    partial class CreateMeeting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMeeting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newMeetingTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newMeetingDetails = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.newMeetingInvitees = new System.Windows.Forms.GroupBox();
            this.participantFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inviteeControlPanel = new System.Windows.Forms.Panel();
            this.inviteeSearchPanel = new System.Windows.Forms.Panel();
            this.participantInfoLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userToAddBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addParticipantButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newMeetingSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.calendarPanel1 = new MeetingScheduler.CalendarPanel();
            this.newMeetingBtnPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.newMeetingSaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.newMeetingInvitees.SuspendLayout();
            this.inviteeControlPanel.SuspendLayout();
            this.inviteeSearchPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.newMeetingSlotsGroupBox.SuspendLayout();
            this.newMeetingBtnPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newMeetingTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1069, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meeting Title";
            // 
            // newMeetingTitle
            // 
            this.newMeetingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingTitle.Location = new System.Drawing.Point(6, 18);
            this.newMeetingTitle.Name = "newMeetingTitle";
            this.newMeetingTitle.Size = new System.Drawing.Size(1057, 19);
            this.newMeetingTitle.TabIndex = 0;
            this.newMeetingTitle.Text = "Your Meeting Title";
            this.newMeetingTitle.TextChanged += new System.EventHandler(this.newMeetingTitle_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newMeetingDetails);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1069, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Details";
            // 
            // newMeetingDetails
            // 
            this.newMeetingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingDetails.Location = new System.Drawing.Point(6, 37);
            this.newMeetingDetails.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.newMeetingDetails.Multiline = true;
            this.newMeetingDetails.Name = "newMeetingDetails";
            this.newMeetingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newMeetingDetails.Size = new System.Drawing.Size(1057, 173);
            this.newMeetingDetails.TabIndex = 0;
            this.newMeetingDetails.Text = "Your meeting description...";
            this.newMeetingDetails.TextChanged += new System.EventHandler(this.newMeetingDetails_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(6, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1057, 19);
            this.panel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(120, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 3, 0, 0);
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "hours long";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // newMeetingInvitees
            // 
            this.newMeetingInvitees.Controls.Add(this.participantFlowPanel);
            this.newMeetingInvitees.Controls.Add(this.inviteeControlPanel);
            this.newMeetingInvitees.Dock = System.Windows.Forms.DockStyle.Left;
            this.newMeetingInvitees.Location = new System.Drawing.Point(0, 0);
            this.newMeetingInvitees.Name = "newMeetingInvitees";
            this.newMeetingInvitees.Padding = new System.Windows.Forms.Padding(6);
            this.newMeetingInvitees.Size = new System.Drawing.Size(413, 358);
            this.newMeetingInvitees.TabIndex = 2;
            this.newMeetingInvitees.TabStop = false;
            this.newMeetingInvitees.Text = "Meeting Invitees";
            // 
            // participantFlowPanel
            // 
            this.participantFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantFlowPanel.Location = new System.Drawing.Point(6, 80);
            this.participantFlowPanel.Name = "participantFlowPanel";
            this.participantFlowPanel.Size = new System.Drawing.Size(401, 272);
            this.participantFlowPanel.TabIndex = 1;
            // 
            // inviteeControlPanel
            // 
            this.inviteeControlPanel.Controls.Add(this.inviteeSearchPanel);
            this.inviteeControlPanel.Controls.Add(this.tableLayoutPanel1);
            this.inviteeControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inviteeControlPanel.Location = new System.Drawing.Point(6, 18);
            this.inviteeControlPanel.Name = "inviteeControlPanel";
            this.inviteeControlPanel.Size = new System.Drawing.Size(401, 62);
            this.inviteeControlPanel.TabIndex = 2;
            // 
            // inviteeSearchPanel
            // 
            this.inviteeSearchPanel.Controls.Add(this.participantInfoLbl);
            this.inviteeSearchPanel.Controls.Add(this.panel6);
            this.inviteeSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inviteeSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.inviteeSearchPanel.Name = "inviteeSearchPanel";
            this.inviteeSearchPanel.Size = new System.Drawing.Size(401, 43);
            this.inviteeSearchPanel.TabIndex = 2;
            // 
            // participantInfoLbl
            // 
            this.participantInfoLbl.AutoSize = true;
            this.participantInfoLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.participantInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantInfoLbl.Location = new System.Drawing.Point(0, 22);
            this.participantInfoLbl.Name = "participantInfoLbl";
            this.participantInfoLbl.Size = new System.Drawing.Size(129, 13);
            this.participantInfoLbl.TabIndex = 5;
            this.participantInfoLbl.Text = "Participant Info Label";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userToAddBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.addParticipantButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 22);
            this.panel6.TabIndex = 4;
            // 
            // userToAddBox
            // 
            this.userToAddBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.userToAddBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userToAddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userToAddBox.FormattingEnabled = true;
            this.userToAddBox.Location = new System.Drawing.Point(54, 0);
            this.userToAddBox.Name = "userToAddBox";
            this.userToAddBox.Size = new System.Drawing.Size(305, 20);
            this.userToAddBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6);
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search:";
            // 
            // addParticipantButton
            // 
            this.addParticipantButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addParticipantButton.Location = new System.Drawing.Point(359, 0);
            this.addParticipantButton.Name = "addParticipantButton";
            this.addParticipantButton.Size = new System.Drawing.Size(42, 22);
            this.addParticipantButton.TabIndex = 1;
            this.addParticipantButton.Text = "Add";
            this.addParticipantButton.UseVisualStyleBackColor = true;
            this.addParticipantButton.Click += new System.EventHandler(this.AddParticipantBtnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 19);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remove";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(73, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(194, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newMeetingSlotsGroupBox
            // 
            this.newMeetingSlotsGroupBox.Controls.Add(this.calendarPanel1);
            this.newMeetingSlotsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingSlotsGroupBox.Location = new System.Drawing.Point(413, 0);
            this.newMeetingSlotsGroupBox.Name = "newMeetingSlotsGroupBox";
            this.newMeetingSlotsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.newMeetingSlotsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newMeetingSlotsGroupBox.Size = new System.Drawing.Size(656, 358);
            this.newMeetingSlotsGroupBox.TabIndex = 3;
            this.newMeetingSlotsGroupBox.TabStop = false;
            this.newMeetingSlotsGroupBox.Text = "Meeting Slots";
            // 
            // calendarPanel1
            // 
            this.calendarPanel1.CurrentWeek = new System.DateTime(2020, 12, 6, 0, 0, 0, 0);
            this.calendarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel1.editedMeeting = null;
            this.calendarPanel1.Location = new System.Drawing.Point(6, 18);
            this.calendarPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarPanel1.meetings = new MeetingScheduler.Meeting[0];
            this.calendarPanel1.Name = "calendarPanel1";
            this.calendarPanel1.Size = new System.Drawing.Size(644, 334);
            this.calendarPanel1.TabIndex = 0;
            // 
            // newMeetingBtnPanel
            // 
            this.newMeetingBtnPanel.Controls.Add(this.cancelBtn);
            this.newMeetingBtnPanel.Controls.Add(this.newMeetingSaveBtn);
            this.newMeetingBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newMeetingBtnPanel.Location = new System.Drawing.Point(0, 620);
            this.newMeetingBtnPanel.Name = "newMeetingBtnPanel";
            this.newMeetingBtnPanel.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.newMeetingBtnPanel.Size = new System.Drawing.Size(1069, 32);
            this.newMeetingBtnPanel.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelBtn.Location = new System.Drawing.Point(889, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 26);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel meeting";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // newMeetingSaveBtn
            // 
            this.newMeetingSaveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMeetingSaveBtn.Location = new System.Drawing.Point(988, 3);
            this.newMeetingSaveBtn.Name = "newMeetingSaveBtn";
            this.newMeetingSaveBtn.Size = new System.Drawing.Size(75, 26);
            this.newMeetingSaveBtn.TabIndex = 0;
            this.newMeetingSaveBtn.Text = "Create";
            this.newMeetingSaveBtn.UseVisualStyleBackColor = true;
            this.newMeetingSaveBtn.Click += new System.EventHandler(this.newMeetingSaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 262);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newMeetingSlotsGroupBox);
            this.panel2.Controls.Add(this.newMeetingInvitees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 358);
            this.panel2.TabIndex = 5;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newMeetingBtnPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1085, 691);
            this.Name = "CreateMeeting";
            this.Text = "Create Meeting - SECM:Meet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateMeeting_FormClosing);
            this.Load += new System.EventHandler(this.CreateMeeting_Load);
            this.ResizeBegin += new System.EventHandler(this.CreateMeeting_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.CreateMeeting_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.newMeetingInvitees.ResumeLayout(false);
            this.inviteeControlPanel.ResumeLayout(false);
            this.inviteeSearchPanel.ResumeLayout(false);
            this.inviteeSearchPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.newMeetingSlotsGroupBox.ResumeLayout(false);
            this.newMeetingBtnPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newMeetingTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newMeetingDetails;
        private System.Windows.Forms.GroupBox newMeetingInvitees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox newMeetingSlotsGroupBox;
        private System.Windows.Forms.Panel newMeetingBtnPanel;
        private System.Windows.Forms.Button newMeetingSaveBtn;
        private CalendarPanel calendarPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel participantFlowPanel;
        private System.Windows.Forms.Panel inviteeControlPanel;
        private System.Windows.Forms.Button addParticipantButton;
        private System.Windows.Forms.Panel inviteeSearchPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userToAddBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label participantInfoLbl;
        private System.Windows.Forms.Button cancelBtn;
    }
}