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
            this.newMeetingSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.newMeetingBtnPanel = new System.Windows.Forms.Panel();
            this.newMeetingSaveBtn = new System.Windows.Forms.Button();
            this.newMeetingCancelBtn = new System.Windows.Forms.Button();
            this.calendarPanel1 = new MeetingScheduler.CalendarPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.newMeetingInvitees.SuspendLayout();
            this.newMeetingSlotsGroupBox.SuspendLayout();
            this.newMeetingBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newMeetingTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meeting Title";
            // 
            // newMeetingTitle
            // 
            this.newMeetingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingTitle.Location = new System.Drawing.Point(3, 22);
            this.newMeetingTitle.Name = "newMeetingTitle";
            this.newMeetingTitle.Size = new System.Drawing.Size(693, 26);
            this.newMeetingTitle.TabIndex = 0;
            this.newMeetingTitle.Text = "Your Meeting Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newMeetingDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Details";
            // 
            // newMeetingDetails
            // 
            this.newMeetingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingDetails.Location = new System.Drawing.Point(3, 22);
            this.newMeetingDetails.Multiline = true;
            this.newMeetingDetails.Name = "newMeetingDetails";
            this.newMeetingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newMeetingDetails.Size = new System.Drawing.Size(693, 172);
            this.newMeetingDetails.TabIndex = 0;
            this.newMeetingDetails.Text = "Your meeting details...";
            // 
            // newMeetingInvitees
            // 
            this.newMeetingInvitees.Controls.Add(this.tableLayoutPanel1);
            this.newMeetingInvitees.Dock = System.Windows.Forms.DockStyle.Left;
            this.newMeetingInvitees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMeetingInvitees.Location = new System.Drawing.Point(0, 251);
            this.newMeetingInvitees.Name = "newMeetingInvitees";
            this.newMeetingInvitees.Size = new System.Drawing.Size(289, 390);
            this.newMeetingInvitees.TabIndex = 2;
            this.newMeetingInvitees.TabStop = false;
            this.newMeetingInvitees.Text = "Meeting Invitees";
            this.newMeetingInvitees.Enter += new System.EventHandler(this.newMeetingInvitees_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.47369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // newMeetingSlotsGroupBox
            // 
            this.newMeetingSlotsGroupBox.Controls.Add(this.calendarPanel1);
            this.newMeetingSlotsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newMeetingSlotsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMeetingSlotsGroupBox.Location = new System.Drawing.Point(289, 251);
            this.newMeetingSlotsGroupBox.Name = "newMeetingSlotsGroupBox";
            this.newMeetingSlotsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newMeetingSlotsGroupBox.Size = new System.Drawing.Size(410, 390);
            this.newMeetingSlotsGroupBox.TabIndex = 3;
            this.newMeetingSlotsGroupBox.TabStop = false;
            this.newMeetingSlotsGroupBox.Text = "Meeting Slots";
            // 
            // newMeetingBtnPanel
            // 
            this.newMeetingBtnPanel.Controls.Add(this.newMeetingCancelBtn);
            this.newMeetingBtnPanel.Controls.Add(this.newMeetingSaveBtn);
            this.newMeetingBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newMeetingBtnPanel.Location = new System.Drawing.Point(0, 641);
            this.newMeetingBtnPanel.Name = "newMeetingBtnPanel";
            this.newMeetingBtnPanel.Padding = new System.Windows.Forms.Padding(3);
            this.newMeetingBtnPanel.Size = new System.Drawing.Size(699, 35);
            this.newMeetingBtnPanel.TabIndex = 4;
            // 
            // newMeetingSaveBtn
            // 
            this.newMeetingSaveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMeetingSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMeetingSaveBtn.Location = new System.Drawing.Point(621, 3);
            this.newMeetingSaveBtn.Name = "newMeetingSaveBtn";
            this.newMeetingSaveBtn.Size = new System.Drawing.Size(75, 29);
            this.newMeetingSaveBtn.TabIndex = 0;
            this.newMeetingSaveBtn.Text = "Create";
            this.newMeetingSaveBtn.UseVisualStyleBackColor = true;
            // 
            // newMeetingCancelBtn
            // 
            this.newMeetingCancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.newMeetingCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMeetingCancelBtn.Location = new System.Drawing.Point(546, 3);
            this.newMeetingCancelBtn.Name = "newMeetingCancelBtn";
            this.newMeetingCancelBtn.Size = new System.Drawing.Size(75, 29);
            this.newMeetingCancelBtn.TabIndex = 1;
            this.newMeetingCancelBtn.Text = "Cancel";
            this.newMeetingCancelBtn.UseVisualStyleBackColor = true;
            this.newMeetingCancelBtn.Click += new System.EventHandler(this.newMeetingCancelBtn_Click);
            // 
            // calendarPanel1
            // 
            this.calendarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel1.Location = new System.Drawing.Point(3, 22);
            this.calendarPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarPanel1.Name = "calendarPanel1";
            this.calendarPanel1.Size = new System.Drawing.Size(404, 365);
            this.calendarPanel1.TabIndex = 0;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 676);
            this.Controls.Add(this.newMeetingSlotsGroupBox);
            this.Controls.Add(this.newMeetingInvitees);
            this.Controls.Add(this.newMeetingBtnPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(715, 715);
            this.Name = "CreateMeeting";
            this.Text = "Create Meeting - Meeting Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.newMeetingInvitees.ResumeLayout(false);
            this.newMeetingSlotsGroupBox.ResumeLayout(false);
            this.newMeetingBtnPanel.ResumeLayout(false);
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
    }
}