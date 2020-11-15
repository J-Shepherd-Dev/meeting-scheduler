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
            this.yourMeetingsTab = new System.Windows.Forms.TabPage();
            this.scheduledTab = new System.Windows.Forms.TabPage();
            this.proposedTab = new System.Windows.Forms.TabPage();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.yourMeetingsTab);
            this.tabControl1.Controls.Add(this.proposedTab);
            this.tabControl1.Controls.Add(this.scheduledTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // yourMeetingsTab
            // 
            this.yourMeetingsTab.Location = new System.Drawing.Point(4, 22);
            this.yourMeetingsTab.Name = "yourMeetingsTab";
            this.yourMeetingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.yourMeetingsTab.Size = new System.Drawing.Size(280, 650);
            this.yourMeetingsTab.TabIndex = 0;
            this.yourMeetingsTab.Text = "Your Meetings";
            this.yourMeetingsTab.UseVisualStyleBackColor = true;
            // 
            // scheduledTab
            // 
            this.scheduledTab.Location = new System.Drawing.Point(4, 22);
            this.scheduledTab.Name = "scheduledTab";
            this.scheduledTab.Padding = new System.Windows.Forms.Padding(3);
            this.scheduledTab.Size = new System.Drawing.Size(280, 644);
            this.scheduledTab.TabIndex = 1;
            this.scheduledTab.Text = "Scheduled";
            this.scheduledTab.UseVisualStyleBackColor = true;
            // 
            // proposedTab
            // 
            this.proposedTab.Location = new System.Drawing.Point(4, 22);
            this.proposedTab.Name = "proposedTab";
            this.proposedTab.Padding = new System.Windows.Forms.Padding(3);
            this.proposedTab.Size = new System.Drawing.Size(280, 644);
            this.proposedTab.TabIndex = 2;
            this.proposedTab.Text = "Proposed";
            this.proposedTab.UseVisualStyleBackColor = true;
            // 
            // detailsBox
            // 
            this.detailsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsBox.Location = new System.Drawing.Point(288, 0);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(431, 676);
            this.detailsBox.TabIndex = 1;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Details Pane";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 676);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(735, 715);
            this.Name = "MainForm";
            this.Text = "SECM Meeting Scheduler - Group 4 2020/21";
            this.ResizeEnd += new System.EventHandler(this.ResizeWindow);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage yourMeetingsTab;
        private System.Windows.Forms.TabPage proposedTab;
        private System.Windows.Forms.TabPage scheduledTab;
        private System.Windows.Forms.GroupBox detailsBox;
    }
}

