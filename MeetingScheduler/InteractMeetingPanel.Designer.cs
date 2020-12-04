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
            this.label1 = new System.Windows.Forms.Label();
            this.attendYesBtn = new System.Windows.Forms.Button();
            this.attendNoBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.meetingTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meetingDescTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.equipmentGB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.participantGB = new System.Windows.Forms.GroupBox();
            this.participantFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.locationCheckList = new System.Windows.Forms.CheckedListBox();
            this.equipmentCheckList = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.equipmentGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.participantGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.attendYesBtn);
            this.panel2.Controls.Add(this.attendNoBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.meetingTitleLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 44);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attending:";
            // 
            // attendYesBtn
            // 
            this.attendYesBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.attendYesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendYesBtn.Location = new System.Drawing.Point(414, 0);
            this.attendYesBtn.Name = "attendYesBtn";
            this.attendYesBtn.Size = new System.Drawing.Size(75, 44);
            this.attendYesBtn.TabIndex = 3;
            this.attendYesBtn.Text = "Yes";
            this.attendYesBtn.UseVisualStyleBackColor = false;
            // 
            // attendNoBtn
            // 
            this.attendNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.attendNoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendNoBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.attendNoBtn.Location = new System.Drawing.Point(489, 0);
            this.attendNoBtn.Name = "attendNoBtn";
            this.attendNoBtn.Size = new System.Drawing.Size(75, 44);
            this.attendNoBtn.TabIndex = 2;
            this.attendNoBtn.Text = "No";
            this.attendNoBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.editBtn.Location = new System.Drawing.Point(564, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 44);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(651, 132);
            this.panel1.TabIndex = 2;
            // 
            // meetingDescTB
            // 
            this.meetingDescTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingDescTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetingDescTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingDescTB.Location = new System.Drawing.Point(6, 50);
            this.meetingDescTB.Margin = new System.Windows.Forms.Padding(12);
            this.meetingDescTB.Multiline = true;
            this.meetingDescTB.Name = "meetingDescTB";
            this.meetingDescTB.ReadOnly = true;
            this.meetingDescTB.Size = new System.Drawing.Size(639, 76);
            this.meetingDescTB.TabIndex = 3;
            this.meetingDescTB.Text = "meetingDescription";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentGB);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(651, 378);
            this.panel3.TabIndex = 3;
            // 
            // equipmentGB
            // 
            this.equipmentGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equipmentGB.Controls.Add(this.equipmentCheckList);
            this.equipmentGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentGB.Location = new System.Drawing.Point(6, 6);
            this.equipmentGB.Name = "equipmentGB";
            this.equipmentGB.Size = new System.Drawing.Size(313, 366);
            this.equipmentGB.TabIndex = 0;
            this.equipmentGB.TabStop = false;
            this.equipmentGB.Text = "Your Equipment Requests";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.locationCheckList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(319, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Location Preference";
            // 
            // participantGB
            // 
            this.participantGB.Controls.Add(this.participantFlowPanel);
            this.participantGB.Dock = System.Windows.Forms.DockStyle.Right;
            this.participantGB.Location = new System.Drawing.Point(651, 0);
            this.participantGB.Name = "participantGB";
            this.participantGB.Size = new System.Drawing.Size(279, 510);
            this.participantGB.TabIndex = 4;
            this.participantGB.TabStop = false;
            this.participantGB.Text = "Participants";
            // 
            // participantFlowPanel
            // 
            this.participantFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.participantFlowPanel.Name = "participantFlowPanel";
            this.participantFlowPanel.Size = new System.Drawing.Size(273, 491);
            this.participantFlowPanel.TabIndex = 0;
            // 
            // locationCheckList
            // 
            this.locationCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.locationCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationCheckList.FormattingEnabled = true;
            this.locationCheckList.Location = new System.Drawing.Point(3, 16);
            this.locationCheckList.Name = "locationCheckList";
            this.locationCheckList.Size = new System.Drawing.Size(320, 347);
            this.locationCheckList.TabIndex = 0;
            // 
            // equipmentCheckList
            // 
            this.equipmentCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.equipmentCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentCheckList.FormattingEnabled = true;
            this.equipmentCheckList.Location = new System.Drawing.Point(3, 16);
            this.equipmentCheckList.Name = "equipmentCheckList";
            this.equipmentCheckList.Size = new System.Drawing.Size(307, 347);
            this.equipmentCheckList.TabIndex = 0;
            // 
            // InteractMeetingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.participantGB);
            this.Name = "InteractMeetingPanel";
            this.Size = new System.Drawing.Size(930, 510);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.equipmentGB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.participantGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label meetingTitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attendYesBtn;
        private System.Windows.Forms.Button attendNoBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox meetingDescTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox equipmentGB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox participantGB;
        private System.Windows.Forms.FlowLayoutPanel participantFlowPanel;
        private System.Windows.Forms.CheckedListBox equipmentCheckList;
        private System.Windows.Forms.CheckedListBox locationCheckList;
    }
}
