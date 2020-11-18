namespace MeetingScheduler
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.yourMeetingsTab = new System.Windows.Forms.TabPage();
            this.proposedTab = new System.Windows.Forms.TabPage();
            this.scheduledTab = new System.Windows.Forms.TabPage();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.devWindowBtn = new System.Windows.Forms.Button();
            this.impersonationComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.yourMeetingsTab);
            this.tabControl1.Controls.Add(this.proposedTab);
            this.tabControl1.Controls.Add(this.scheduledTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 649);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // yourMeetingsTab
            // 
            this.yourMeetingsTab.Location = new System.Drawing.Point(4, 22);
            this.yourMeetingsTab.Name = "yourMeetingsTab";
            this.yourMeetingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.yourMeetingsTab.Size = new System.Drawing.Size(226, 623);
            this.yourMeetingsTab.TabIndex = 0;
            this.yourMeetingsTab.Text = "Your Meetings";
            this.yourMeetingsTab.UseVisualStyleBackColor = true;
            this.yourMeetingsTab.Click += new System.EventHandler(this.yourMeetingsTab_Click);
            // 
            // proposedTab
            // 
            this.proposedTab.Location = new System.Drawing.Point(4, 22);
            this.proposedTab.Name = "proposedTab";
            this.proposedTab.Padding = new System.Windows.Forms.Padding(3);
            this.proposedTab.Size = new System.Drawing.Size(226, 623);
            this.proposedTab.TabIndex = 2;
            this.proposedTab.Text = "Proposed";
            this.proposedTab.UseVisualStyleBackColor = true;
            // 
            // scheduledTab
            // 
            this.scheduledTab.Location = new System.Drawing.Point(4, 22);
            this.scheduledTab.Name = "scheduledTab";
            this.scheduledTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduledTab.Size = new System.Drawing.Size(226, 623);
            this.scheduledTab.TabIndex = 1;
            this.scheduledTab.Text = "Scheduled";
            this.scheduledTab.UseVisualStyleBackColor = true;
            // 
            // detailsBox
            // 
            this.detailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsBox.Location = new System.Drawing.Point(234, 0);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(889, 649);
            this.detailsBox.TabIndex = 1;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Details Pane";
            this.detailsBox.Enter += new System.EventHandler(this.detailsBox_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.devWindowBtn);
            this.flowLayoutPanel1.Controls.Add(this.impersonationComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1123, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // devWindowBtn
            // 
            this.devWindowBtn.Location = new System.Drawing.Point(1065, 3);
            this.devWindowBtn.Name = "devWindowBtn";
            this.devWindowBtn.Size = new System.Drawing.Size(55, 23);
            this.devWindowBtn.TabIndex = 2;
            this.devWindowBtn.Text = "Dev log";
            this.devWindowBtn.UseVisualStyleBackColor = true;
            this.devWindowBtn.Click += new System.EventHandler(this.devWindowBtn_Click);
            // 
            // impersonationComboBox
            // 
            this.impersonationComboBox.DataSource = this.userBindingSource;
            this.impersonationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.impersonationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.impersonationComboBox.FormattingEnabled = true;
            this.impersonationComboBox.Location = new System.Drawing.Point(888, 3);
            this.impersonationComboBox.Name = "impersonationComboBox";
            this.impersonationComboBox.Size = new System.Drawing.Size(171, 21);
            this.impersonationComboBox.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MeetingScheduler.User);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(806, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Impersonating:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detailsBox);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 649);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(735, 715);
            this.Name = "MainForm";
            this.Text = "SECM Meeting Scheduler - Group 4 2020/21";
            this.ResizeEnd += new System.EventHandler(this.ResizeWindow);
            this.tabControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage yourMeetingsTab;
        private System.Windows.Forms.TabPage proposedTab;
        private System.Windows.Forms.TabPage scheduledTab;
        private System.Windows.Forms.GroupBox detailsBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox impersonationComboBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button devWindowBtn;
    }
}

