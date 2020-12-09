namespace MeetingScheduler
{
    partial class InteractMeetingPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.attendLabel = new System.Windows.Forms.Label();
            this.attendYesBtn = new System.Windows.Forms.Button();
            this.attendNoBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.viewRequestsBtn = new System.Windows.Forms.Button();
            this.meetingTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meetingDescTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimeInfoLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.equipmentGB = new System.Windows.Forms.GroupBox();
            this.equipmentCheckList = new System.Windows.Forms.CheckedListBox();
            this.locationGB = new System.Windows.Forms.GroupBox();
            this.locationCheckList = new System.Windows.Forms.CheckedListBox();
            this.participantGB = new System.Windows.Forms.GroupBox();
            this.participantFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.meetingInfoBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.equipmentGB.SuspendLayout();
            this.locationGB.SuspendLayout();
            this.participantGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.attendLabel);
            this.panel2.Controls.Add(this.attendYesBtn);
            this.panel2.Controls.Add(this.attendNoBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.viewRequestsBtn);
            this.panel2.Controls.Add(this.meetingTitleLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 37);
            this.panel2.TabIndex = 2;
            // 
            // attendLabel
            // 
            this.attendLabel.AutoSize = true;
            this.attendLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendLabel.Location = new System.Drawing.Point(251, 0);
            this.attendLabel.Name = "attendLabel";
            this.attendLabel.Padding = new System.Windows.Forms.Padding(6, 11, 0, 0);
            this.attendLabel.Size = new System.Drawing.Size(88, 31);
            this.attendLabel.TabIndex = 4;
            this.attendLabel.Text = "Attending:";
            // 
            // attendYesBtn
            // 
            this.attendYesBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.attendYesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendYesBtn.Location = new System.Drawing.Point(339, 0);
            this.attendYesBtn.Name = "attendYesBtn";
            this.attendYesBtn.Size = new System.Drawing.Size(75, 37);
            this.attendYesBtn.TabIndex = 3;
            this.attendYesBtn.Text = "Yes";
            this.attendYesBtn.UseVisualStyleBackColor = false;
            this.attendYesBtn.Click += new System.EventHandler(this.attendYesBtn_Click);
            // 
            // attendNoBtn
            // 
            this.attendNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.attendNoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendNoBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.attendNoBtn.Location = new System.Drawing.Point(414, 0);
            this.attendNoBtn.Name = "attendNoBtn";
            this.attendNoBtn.Size = new System.Drawing.Size(75, 37);
            this.attendNoBtn.TabIndex = 2;
            this.attendNoBtn.Text = "No";
            this.attendNoBtn.UseVisualStyleBackColor = false;
            this.attendNoBtn.Click += new System.EventHandler(this.attendNoBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.editBtn.Location = new System.Drawing.Point(489, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 37);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit Meeting";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // viewRequestsBtn
            // 
            this.viewRequestsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewRequestsBtn.Location = new System.Drawing.Point(564, 0);
            this.viewRequestsBtn.Name = "viewRequestsBtn";
            this.viewRequestsBtn.Size = new System.Drawing.Size(75, 37);
            this.viewRequestsBtn.TabIndex = 5;
            this.viewRequestsBtn.Text = "View Requests";
            this.viewRequestsBtn.UseVisualStyleBackColor = true;
            this.viewRequestsBtn.Click += new System.EventHandler(this.viewRequestsBtn_Click);
            // 
            // meetingTitleLbl
            // 
            this.meetingTitleLbl.AutoSize = true;
            this.meetingTitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetingTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.meetingTitleLbl.Name = "meetingTitleLbl";
            this.meetingTitleLbl.Size = new System.Drawing.Size(142, 26);
            this.meetingTitleLbl.TabIndex = 0;
            this.meetingTitleLbl.Text = "meetingTitle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.meetingDescTB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Size = new System.Drawing.Size(651, 161);
            this.panel1.TabIndex = 2;
            // 
            // meetingDescTB
            // 
            this.meetingDescTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingDescTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetingDescTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingDescTB.Location = new System.Drawing.Point(6, 64);
            this.meetingDescTB.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.meetingDescTB.Multiline = true;
            this.meetingDescTB.Name = "meetingDescTB";
            this.meetingDescTB.ReadOnly = true;
            this.meetingDescTB.Size = new System.Drawing.Size(639, 91);
            this.meetingDescTB.TabIndex = 3;
            this.meetingDescTB.Text = "meetingDescription";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimeInfoLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(6, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 21);
            this.panel4.TabIndex = 4;
            // 
            // dateTimeInfoLbl
            // 
            this.dateTimeInfoLbl.AutoSize = true;
            this.dateTimeInfoLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInfoLbl.Location = new System.Drawing.Point(0, 0);
            this.dateTimeInfoLbl.Name = "dateTimeInfoLbl";
            this.dateTimeInfoLbl.Size = new System.Drawing.Size(52, 17);
            this.dateTimeInfoLbl.TabIndex = 0;
            this.dateTimeInfoLbl.Text = "label1";
            this.dateTimeInfoLbl.Click += new System.EventHandler(this.dateTimeInfoLbl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentGB);
            this.panel3.Controls.Add(this.locationGB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 161);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Size = new System.Drawing.Size(651, 310);
            this.panel3.TabIndex = 3;
            // 
            // equipmentGB
            // 
            this.equipmentGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equipmentGB.Controls.Add(this.equipmentCheckList);
            this.equipmentGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentGB.Location = new System.Drawing.Point(6, 6);
            this.equipmentGB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.equipmentGB.Name = "equipmentGB";
            this.equipmentGB.Size = new System.Drawing.Size(313, 298);
            this.equipmentGB.TabIndex = 0;
            this.equipmentGB.TabStop = false;
            this.equipmentGB.Text = "Your Equipment Requests";
            // 
            // equipmentCheckList
            // 
            this.equipmentCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.equipmentCheckList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentCheckList.FormattingEnabled = true;
            this.equipmentCheckList.Location = new System.Drawing.Point(3, 15);
            this.equipmentCheckList.Name = "equipmentCheckList";
            this.equipmentCheckList.Size = new System.Drawing.Size(307, 280);
            this.equipmentCheckList.TabIndex = 0;
            this.equipmentCheckList.SelectedIndexChanged += new System.EventHandler(this.equipmentCheckList_SelectedIndexChanged);
            // 
            // locationGB
            // 
            this.locationGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locationGB.Controls.Add(this.locationCheckList);
            this.locationGB.Dock = System.Windows.Forms.DockStyle.Right;
            this.locationGB.Location = new System.Drawing.Point(319, 6);
            this.locationGB.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.locationGB.Name = "locationGB";
            this.locationGB.Size = new System.Drawing.Size(326, 298);
            this.locationGB.TabIndex = 1;
            this.locationGB.TabStop = false;
            this.locationGB.Text = "Your Location Preference";
            // 
            // locationCheckList
            // 
            this.locationCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.locationCheckList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationCheckList.FormattingEnabled = true;
            this.locationCheckList.Location = new System.Drawing.Point(3, 15);
            this.locationCheckList.Name = "locationCheckList";
            this.locationCheckList.Size = new System.Drawing.Size(320, 280);
            this.locationCheckList.TabIndex = 0;
            this.locationCheckList.SelectedIndexChanged += new System.EventHandler(this.locationCheckList_SelectedIndexChanged);
            // 
            // participantGB
            // 
            this.participantGB.Controls.Add(this.participantFlowPanel);
            this.participantGB.Controls.Add(this.meetingInfoBox);
            this.participantGB.Dock = System.Windows.Forms.DockStyle.Right;
            this.participantGB.Location = new System.Drawing.Point(651, 0);
            this.participantGB.Name = "participantGB";
            this.participantGB.Size = new System.Drawing.Size(279, 471);
            this.participantGB.TabIndex = 4;
            this.participantGB.TabStop = false;
            this.participantGB.Text = "Information";
            // 
            // participantFlowPanel
            // 
            this.participantFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantFlowPanel.Location = new System.Drawing.Point(3, 65);
            this.participantFlowPanel.Name = "participantFlowPanel";
            this.participantFlowPanel.Size = new System.Drawing.Size(273, 403);
            this.participantFlowPanel.TabIndex = 0;
            // 
            // meetingInfoBox
            // 
            this.meetingInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingInfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetingInfoBox.Location = new System.Drawing.Point(3, 15);
            this.meetingInfoBox.Multiline = true;
            this.meetingInfoBox.Name = "meetingInfoBox";
            this.meetingInfoBox.ReadOnly = true;
            this.meetingInfoBox.Size = new System.Drawing.Size(273, 50);
            this.meetingInfoBox.TabIndex = 1;
            this.meetingInfoBox.Text = "Potential Locations:";
            // 
            // InteractMeetingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.participantGB);
            this.Name = "InteractMeetingPanel";
            this.Size = new System.Drawing.Size(930, 471);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.equipmentGB.ResumeLayout(false);
            this.locationGB.ResumeLayout(false);
            this.participantGB.ResumeLayout(false);
            this.participantGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label meetingTitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label attendLabel;
        private System.Windows.Forms.Button attendYesBtn;
        private System.Windows.Forms.Button attendNoBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox meetingDescTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox equipmentGB;
        private System.Windows.Forms.GroupBox locationGB;
        private System.Windows.Forms.GroupBox participantGB;
        private System.Windows.Forms.FlowLayoutPanel participantFlowPanel;
        private System.Windows.Forms.CheckedListBox equipmentCheckList;
        private System.Windows.Forms.CheckedListBox locationCheckList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dateTimeInfoLbl;
        private System.Windows.Forms.Button viewRequestsBtn;
        private System.Windows.Forms.TextBox meetingInfoBox;
    }
}
