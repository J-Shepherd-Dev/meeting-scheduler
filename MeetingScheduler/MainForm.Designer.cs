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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.initiatedTab = new System.Windows.Forms.TabPage();
            this.initiatedTabList = new System.Windows.Forms.ListBox();
            this.invitedTab = new System.Windows.Forms.TabPage();
            this.invitedTabList = new System.Windows.Forms.ListBox();
            this.scheduledTab = new System.Windows.Forms.TabPage();
            this.scheduledTabList = new System.Windows.Forms.ListBox();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.interactMeetingPanel1 = new MeetingScheduler.InteractMeetingPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.devWindowBtn = new System.Windows.Forms.Button();
            this.impersonationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.initiatedTab.SuspendLayout();
            this.invitedTab.SuspendLayout();
            this.scheduledTab.SuspendLayout();
            this.detailsBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.initiatedTab);
            this.tabControl1.Controls.Add(this.invitedTab);
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
            // initiatedTab
            // 
            this.initiatedTab.Controls.Add(this.initiatedTabList);
            this.initiatedTab.Location = new System.Drawing.Point(4, 22);
            this.initiatedTab.Name = "initiatedTab";
            this.initiatedTab.Padding = new System.Windows.Forms.Padding(3);
            this.initiatedTab.Size = new System.Drawing.Size(226, 623);
            this.initiatedTab.TabIndex = 0;
            this.initiatedTab.Text = "Initiated";
            this.initiatedTab.UseVisualStyleBackColor = true;
            this.initiatedTab.Click += new System.EventHandler(this.yourMeetingsTab_Click);
            // 
            // initiatedTabList
            // 
            this.initiatedTabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initiatedTabList.FormattingEnabled = true;
            this.initiatedTabList.Location = new System.Drawing.Point(3, 3);
            this.initiatedTabList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.initiatedTabList.Name = "initiatedTabList";
            this.initiatedTabList.Size = new System.Drawing.Size(220, 617);
            this.initiatedTabList.TabIndex = 0;
            this.initiatedTabList.SelectedValueChanged += new System.EventHandler(this.initiatedTabList_SelectedValueChanged);
            // 
            // invitedTab
            // 
            this.invitedTab.Controls.Add(this.invitedTabList);
            this.invitedTab.Location = new System.Drawing.Point(4, 22);
            this.invitedTab.Name = "invitedTab";
            this.invitedTab.Padding = new System.Windows.Forms.Padding(3);
            this.invitedTab.Size = new System.Drawing.Size(226, 623);
            this.invitedTab.TabIndex = 2;
            this.invitedTab.Text = "Invited";
            this.invitedTab.UseVisualStyleBackColor = true;
            // 
            // invitedTabList
            // 
            this.invitedTabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitedTabList.FormattingEnabled = true;
            this.invitedTabList.Location = new System.Drawing.Point(3, 3);
            this.invitedTabList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.invitedTabList.Name = "invitedTabList";
            this.invitedTabList.Size = new System.Drawing.Size(220, 617);
            this.invitedTabList.TabIndex = 0;
            this.invitedTabList.SelectedValueChanged += new System.EventHandler(this.invitedTabList_SelectedValueChanged);
            // 
            // scheduledTab
            // 
            this.scheduledTab.Controls.Add(this.scheduledTabList);
            this.scheduledTab.Location = new System.Drawing.Point(4, 22);
            this.scheduledTab.Name = "scheduledTab";
            this.scheduledTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduledTab.Size = new System.Drawing.Size(226, 623);
            this.scheduledTab.TabIndex = 1;
            this.scheduledTab.Text = "Scheduled";
            this.scheduledTab.UseVisualStyleBackColor = true;
            // 
            // scheduledTabList
            // 
            this.scheduledTabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduledTabList.FormattingEnabled = true;
            this.scheduledTabList.Location = new System.Drawing.Point(3, 3);
            this.scheduledTabList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scheduledTabList.Name = "scheduledTabList";
            this.scheduledTabList.Size = new System.Drawing.Size(220, 617);
            this.scheduledTabList.TabIndex = 1;
            this.scheduledTabList.SelectedValueChanged += new System.EventHandler(this.scheduledTabList_SelectedValueChanged);
            // 
            // detailsBox
            // 
            this.detailsBox.Controls.Add(this.interactMeetingPanel1);
            this.detailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsBox.Location = new System.Drawing.Point(234, 0);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(1020, 649);
            this.detailsBox.TabIndex = 1;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Details Pane";
            this.detailsBox.Enter += new System.EventHandler(this.detailsBox_Enter);
            // 
            // interactMeetingPanel1
            // 
            this.interactMeetingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interactMeetingPanel1.Location = new System.Drawing.Point(3, 16);
            this.interactMeetingPanel1.Name = "interactMeetingPanel1";
            this.interactMeetingPanel1.Size = new System.Drawing.Size(1014, 630);
            this.interactMeetingPanel1.TabIndex = 1;
            this.interactMeetingPanel1.Load += new System.EventHandler(this.interactMeetingPanel1_Load);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.resetAllButton);
            this.flowLayoutPanel1.Controls.Add(this.devWindowBtn);
            this.flowLayoutPanel1.Controls.Add(this.impersonationComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1254, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // resetAllButton
            // 
            this.resetAllButton.Location = new System.Drawing.Point(1176, 3);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(75, 25);
            this.resetAllButton.TabIndex = 4;
            this.resetAllButton.Text = "Reset all";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // devWindowBtn
            // 
            this.devWindowBtn.Location = new System.Drawing.Point(1115, 3);
            this.devWindowBtn.Name = "devWindowBtn";
            this.devWindowBtn.Size = new System.Drawing.Size(55, 23);
            this.devWindowBtn.TabIndex = 2;
            this.devWindowBtn.Text = "Dev log";
            this.devWindowBtn.UseVisualStyleBackColor = true;
            this.devWindowBtn.Click += new System.EventHandler(this.devWindowBtn_Click);
            // 
            // impersonationComboBox
            // 
            this.impersonationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.impersonationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.impersonationComboBox.FormattingEnabled = true;
            this.impersonationComboBox.Location = new System.Drawing.Point(938, 3);
            this.impersonationComboBox.Name = "impersonationComboBox";
            this.impersonationComboBox.Size = new System.Drawing.Size(171, 21);
            this.impersonationComboBox.TabIndex = 0;
            this.impersonationComboBox.SelectionChangeCommitted += new System.EventHandler(this.impersonationComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(856, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Impersonating:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detailsBox);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 649);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1270, 715);
            this.Name = "MainForm";
            this.Text = "SECM: Meet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.ResizeWindow);
            this.tabControl1.ResumeLayout(false);
            this.initiatedTab.ResumeLayout(false);
            this.invitedTab.ResumeLayout(false);
            this.scheduledTab.ResumeLayout(false);
            this.detailsBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage initiatedTab;
        private System.Windows.Forms.TabPage invitedTab;
        private System.Windows.Forms.TabPage scheduledTab;
        private System.Windows.Forms.GroupBox detailsBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox impersonationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button devWindowBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox initiatedTabList;
        private System.Windows.Forms.ListBox invitedTabList;
        private System.Windows.Forms.ListBox scheduledTabList;
        private InteractMeetingPanel interactMeetingPanel1;
        private System.Windows.Forms.Button resetAllButton;
    }
}

