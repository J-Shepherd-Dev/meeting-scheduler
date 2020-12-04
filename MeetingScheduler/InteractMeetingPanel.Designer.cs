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
            this.meetingTitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.attendNoBtn = new System.Windows.Forms.Button();
            this.attendYesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.equipmentGB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(918, 44);
            this.panel2.TabIndex = 2;
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
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(930, 190);
            this.panel1.TabIndex = 2;
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.editBtn.Location = new System.Drawing.Point(843, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 44);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // attendNoBtn
            // 
            this.attendNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.attendNoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendNoBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.attendNoBtn.Location = new System.Drawing.Point(768, 0);
            this.attendNoBtn.Name = "attendNoBtn";
            this.attendNoBtn.Size = new System.Drawing.Size(75, 44);
            this.attendNoBtn.TabIndex = 2;
            this.attendNoBtn.Text = "No";
            this.attendNoBtn.UseVisualStyleBackColor = false;
            // 
            // attendYesBtn
            // 
            this.attendYesBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.attendYesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.attendYesBtn.Location = new System.Drawing.Point(693, 0);
            this.attendYesBtn.Name = "attendYesBtn";
            this.attendYesBtn.Size = new System.Drawing.Size(75, 44);
            this.attendYesBtn.TabIndex = 3;
            this.attendYesBtn.Text = "Yes";
            this.attendYesBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 12, 0, 0);
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attending:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(918, 134);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "meetingDescription";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.equipmentGB);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(930, 243);
            this.panel3.TabIndex = 3;
            // 
            // equipmentGB
            // 
            this.equipmentGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equipmentGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentGB.Location = new System.Drawing.Point(6, 6);
            this.equipmentGB.Name = "equipmentGB";
            this.equipmentGB.Size = new System.Drawing.Size(592, 231);
            this.equipmentGB.TabIndex = 0;
            this.equipmentGB.TabStop = false;
            this.equipmentGB.Text = "Your Equipment Requests";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(598, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Location Preference";
            // 
            // InteractMeetingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "InteractMeetingPanel";
            this.Size = new System.Drawing.Size(930, 510);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label meetingTitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attendYesBtn;
        private System.Windows.Forms.Button attendNoBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox equipmentGB;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
