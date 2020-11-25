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
            this.newMeetingInvitees = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newMeetingSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.calendarPanel1 = new MeetingScheduler.CalendarPanel();
            this.newMeetingBtnPanel = new System.Windows.Forms.Panel();
            this.newMeetingCancelBtn = new System.Windows.Forms.Button();
            this.newMeetingSaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.newMeetingInvitees.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(944, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meeting Title";
            // 
            // newMeetingTitle
            // 
            this.newMeetingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingTitle.Location = new System.Drawing.Point(6, 18);
            this.newMeetingTitle.Name = "newMeetingTitle";
            this.newMeetingTitle.Size = new System.Drawing.Size(932, 19);
            this.newMeetingTitle.TabIndex = 0;
            this.newMeetingTitle.Text = "Your Meeting Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newMeetingDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(944, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Details";
            // 
            // newMeetingDetails
            // 
            this.newMeetingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingDetails.Location = new System.Drawing.Point(6, 18);
            this.newMeetingDetails.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.newMeetingDetails.Multiline = true;
            this.newMeetingDetails.Name = "newMeetingDetails";
            this.newMeetingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newMeetingDetails.Size = new System.Drawing.Size(932, 188);
            this.newMeetingDetails.TabIndex = 0;
            this.newMeetingDetails.Text = "Your meeting description...";
            // 
            // newMeetingInvitees
            // 
            this.newMeetingInvitees.Controls.Add(this.tableLayoutPanel1);
            this.newMeetingInvitees.Dock = System.Windows.Forms.DockStyle.Left;
            this.newMeetingInvitees.Location = new System.Drawing.Point(0, 0);
            this.newMeetingInvitees.Name = "newMeetingInvitees";
            this.newMeetingInvitees.Padding = new System.Windows.Forms.Padding(6);
            this.newMeetingInvitees.Size = new System.Drawing.Size(413, 358);
            this.newMeetingInvitees.TabIndex = 2;
            this.newMeetingInvitees.TabStop = false;
            this.newMeetingInvitees.Text = "Meeting Invitees";
            this.newMeetingInvitees.Enter += new System.EventHandler(this.newMeetingInvitees_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.52809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remove";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(60, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(259, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Important?";
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
            this.newMeetingSlotsGroupBox.Size = new System.Drawing.Size(531, 358);
            this.newMeetingSlotsGroupBox.TabIndex = 3;
            this.newMeetingSlotsGroupBox.TabStop = false;
            this.newMeetingSlotsGroupBox.Text = "Meeting Slots";
            // 
            // calendarPanel1
            // 
            this.calendarPanel1.CurrentWeek = new System.DateTime(2020, 11, 22, 0, 0, 0, 0);
            this.calendarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel1.Location = new System.Drawing.Point(6, 18);
            this.calendarPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarPanel1.Name = "calendarPanel1";
            this.calendarPanel1.Size = new System.Drawing.Size(519, 334);
            this.calendarPanel1.TabIndex = 0;
            // 
            // newMeetingBtnPanel
            // 
            this.newMeetingBtnPanel.Controls.Add(this.newMeetingCancelBtn);
            this.newMeetingBtnPanel.Controls.Add(this.newMeetingSaveBtn);
            this.newMeetingBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newMeetingBtnPanel.Location = new System.Drawing.Point(0, 620);
            this.newMeetingBtnPanel.Name = "newMeetingBtnPanel";
            this.newMeetingBtnPanel.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.newMeetingBtnPanel.Size = new System.Drawing.Size(944, 32);
            this.newMeetingBtnPanel.TabIndex = 4;
            // 
            // newMeetingCancelBtn
            // 
            this.newMeetingCancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMeetingCancelBtn.Location = new System.Drawing.Point(788, 3);
            this.newMeetingCancelBtn.Name = "newMeetingCancelBtn";
            this.newMeetingCancelBtn.Size = new System.Drawing.Size(75, 26);
            this.newMeetingCancelBtn.TabIndex = 1;
            this.newMeetingCancelBtn.Text = "Cancel";
            this.newMeetingCancelBtn.UseVisualStyleBackColor = true;
            this.newMeetingCancelBtn.Click += new System.EventHandler(this.newMeetingCancelBtn_Click);
            // 
            // newMeetingSaveBtn
            // 
            this.newMeetingSaveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMeetingSaveBtn.Location = new System.Drawing.Point(863, 3);
            this.newMeetingSaveBtn.Name = "newMeetingSaveBtn";
            this.newMeetingSaveBtn.Size = new System.Drawing.Size(75, 26);
            this.newMeetingSaveBtn.TabIndex = 0;
            this.newMeetingSaveBtn.Text = "Create";
            this.newMeetingSaveBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 262);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newMeetingSlotsGroupBox);
            this.panel2.Controls.Add(this.newMeetingInvitees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 358);
            this.panel2.TabIndex = 5;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newMeetingBtnPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 691);
            this.Name = "CreateMeeting";
            this.Text = "Create Meeting - SECM:Meet";
            this.Load += new System.EventHandler(this.CreateMeeting_Load);
            this.ResizeBegin += new System.EventHandler(this.CreateMeeting_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.CreateMeeting_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.newMeetingInvitees.ResumeLayout(false);
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
        private System.Windows.Forms.Button newMeetingCancelBtn;
        private System.Windows.Forms.Button newMeetingSaveBtn;
        private CalendarPanel calendarPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}