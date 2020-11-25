namespace MeetingScheduler
{
    partial class CalendarPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWeek = new System.Windows.Forms.Label();
            this.buttonLastWeek = new System.Windows.Forms.Button();
            this.buttonNextWeek = new System.Windows.Forms.Button();
            this.flowWeekday = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelWeek
            // 
            this.labelWeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWeek.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWeek.Location = new System.Drawing.Point(100, 8);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(600, 20);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "this is a CalendarPanel";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLastWeek
            // 
            this.buttonLastWeek.Location = new System.Drawing.Point(0, 0);
            this.buttonLastWeek.Name = "buttonLastWeek";
            this.buttonLastWeek.Size = new System.Drawing.Size(100, 30);
            this.buttonLastWeek.TabIndex = 1;
            this.buttonLastWeek.Text = "<";
            this.buttonLastWeek.UseVisualStyleBackColor = true;
            this.buttonLastWeek.Click += new System.EventHandler(this.buttonLastWeek_Click);
            // 
            // buttonNextWeek
            // 
            this.buttonNextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextWeek.Location = new System.Drawing.Point(700, 0);
            this.buttonNextWeek.Name = "buttonNextWeek";
            this.buttonNextWeek.Size = new System.Drawing.Size(100, 30);
            this.buttonNextWeek.TabIndex = 2;
            this.buttonNextWeek.Text = ">";
            this.buttonNextWeek.UseVisualStyleBackColor = true;
            this.buttonNextWeek.Click += new System.EventHandler(this.buttonNextWeek_Click);
            // 
            // flowWeekday
            // 
            this.flowWeekday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowWeekday.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowWeekday.Location = new System.Drawing.Point(0, 31);
            this.flowWeekday.Name = "flowWeekday";
            this.flowWeekday.Size = new System.Drawing.Size(799, 468);
            this.flowWeekday.TabIndex = 3;
            // 
            // CalendarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flowWeekday);
            this.Controls.Add(this.buttonNextWeek);
            this.Controls.Add(this.buttonLastWeek);
            this.Controls.Add(this.labelWeek);
            this.Name = "CalendarPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.CalendarPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Button buttonLastWeek;
        private System.Windows.Forms.Button buttonNextWeek;
        private System.Windows.Forms.FlowLayoutPanel flowWeekday;
    }
}
