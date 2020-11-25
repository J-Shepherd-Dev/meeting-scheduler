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
            this.calendarPanelDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWeek
            // 
            this.labelWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWeek.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWeek.Location = new System.Drawing.Point(0, 0);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(600, 22);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "this is a CalendarPanel";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLastWeek
            // 
            this.buttonLastWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLastWeek.Location = new System.Drawing.Point(0, 0);
            this.buttonLastWeek.Name = "buttonLastWeek";
            this.buttonLastWeek.Size = new System.Drawing.Size(100, 46);
            this.buttonLastWeek.TabIndex = 1;
            this.buttonLastWeek.Text = "<";
            this.buttonLastWeek.UseVisualStyleBackColor = true;
            this.buttonLastWeek.Click += new System.EventHandler(this.buttonLastWeek_Click);
            // 
            // buttonNextWeek
            // 
            this.buttonNextWeek.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextWeek.Location = new System.Drawing.Point(700, 0);
            this.buttonNextWeek.Name = "buttonNextWeek";
            this.buttonNextWeek.Size = new System.Drawing.Size(100, 46);
            this.buttonNextWeek.TabIndex = 2;
            this.buttonNextWeek.Text = ">";
            this.buttonNextWeek.UseVisualStyleBackColor = true;
            this.buttonNextWeek.Click += new System.EventHandler(this.buttonNextWeek_Click);
            // 
            // flowWeekday
            // 
            this.flowWeekday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowWeekday.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowWeekday.Location = new System.Drawing.Point(0, 46);
            this.flowWeekday.Name = "flowWeekday";
            this.flowWeekday.Size = new System.Drawing.Size(800, 496);
            this.flowWeekday.TabIndex = 3;
            // 
            // calendarPanelDatePicker
            // 
            this.calendarPanelDatePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calendarPanelDatePicker.Location = new System.Drawing.Point(0, 26);
            this.calendarPanelDatePicker.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.calendarPanelDatePicker.Name = "calendarPanelDatePicker";
            this.calendarPanelDatePicker.Size = new System.Drawing.Size(600, 20);
            this.calendarPanelDatePicker.TabIndex = 0;
            this.calendarPanelDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonNextWeek);
            this.panel1.Controls.Add(this.buttonLastWeek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calendarPanelDatePicker);
            this.panel2.Controls.Add(this.labelWeek);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 46);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CalendarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flowWeekday);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarPanel";
            this.Size = new System.Drawing.Size(800, 542);
            this.Load += new System.EventHandler(this.CalendarPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Button buttonLastWeek;
        private System.Windows.Forms.Button buttonNextWeek;
        private System.Windows.Forms.FlowLayoutPanel flowWeekday;
        private System.Windows.Forms.DateTimePicker calendarPanelDatePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
