namespace MeetingScheduler
{
    partial class DevLogForm
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
            this.devLogFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // devLogFlowPanel
            // 
            this.devLogFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.devLogFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devLogFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.devLogFlowPanel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devLogFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.devLogFlowPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.devLogFlowPanel.Name = "devLogFlowPanel";
            this.devLogFlowPanel.Size = new System.Drawing.Size(720, 552);
            this.devLogFlowPanel.TabIndex = 0;
            // 
            // DevLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 552);
            this.Controls.Add(this.devLogFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevLogForm";
            this.ShowIcon = false;
            this.Text = "Meeting Scheduler Developer Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevLogForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel devLogFlowPanel;
    }
}