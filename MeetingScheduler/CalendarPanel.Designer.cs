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
            this.calendarPanelDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weekdayLabel7 = new System.Windows.Forms.Label();
            this.weekdayLabel6 = new System.Windows.Forms.Label();
            this.weekdayLabel5 = new System.Windows.Forms.Label();
            this.weekdayLabel4 = new System.Windows.Forms.Label();
            this.weekdayLabel3 = new System.Windows.Forms.Label();
            this.weekdayLabel2 = new System.Windows.Forms.Label();
            this.timeLabel11 = new System.Windows.Forms.Label();
            this.timeLabel10 = new System.Windows.Forms.Label();
            this.timeLabel9 = new System.Windows.Forms.Label();
            this.timeLabel8 = new System.Windows.Forms.Label();
            this.timeLabel7 = new System.Windows.Forms.Label();
            this.timeLabel6 = new System.Windows.Forms.Label();
            this.timeLabel5 = new System.Windows.Forms.Label();
            this.timeLabel4 = new System.Windows.Forms.Label();
            this.timeLabel3 = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.weekdayLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWeek
            // 
            this.labelWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWeek.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWeek.Location = new System.Drawing.Point(0, 0);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(600, 20);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "this is a CalendarPanel";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLastWeek
            // 
            this.buttonLastWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLastWeek.Location = new System.Drawing.Point(0, 0);
            this.buttonLastWeek.Name = "buttonLastWeek";
            this.buttonLastWeek.Size = new System.Drawing.Size(100, 42);
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
            this.buttonNextWeek.Size = new System.Drawing.Size(100, 42);
            this.buttonNextWeek.TabIndex = 2;
            this.buttonNextWeek.Text = ">";
            this.buttonNextWeek.UseVisualStyleBackColor = true;
            this.buttonNextWeek.Click += new System.EventHandler(this.buttonNextWeek_Click);
            // 
            // calendarPanelDatePicker
            // 
            this.calendarPanelDatePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calendarPanelDatePicker.Location = new System.Drawing.Point(0, 23);
            this.calendarPanelDatePicker.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.calendarPanelDatePicker.Name = "calendarPanelDatePicker";
            this.calendarPanelDatePicker.Size = new System.Drawing.Size(600, 19);
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
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calendarPanelDatePicker);
            this.panel2.Controls.Add(this.labelWeek);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 42);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.939084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.823718F));
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel11, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel10, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.weekdayLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 5, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 458);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // weekdayLabel7
            // 
            this.weekdayLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel7.Location = new System.Drawing.Point(4, 391);
            this.weekdayLabel7.Name = "weekdayLabel7";
            this.weekdayLabel7.Size = new System.Drawing.Size(17, 66);
            this.weekdayLabel7.TabIndex = 18;
            this.weekdayLabel7.Text = "Sa";
            this.weekdayLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekdayLabel6
            // 
            this.weekdayLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel6.Location = new System.Drawing.Point(4, 331);
            this.weekdayLabel6.Name = "weekdayLabel6";
            this.weekdayLabel6.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel6.TabIndex = 17;
            this.weekdayLabel6.Text = "F";
            this.weekdayLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekdayLabel5
            // 
            this.weekdayLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel5.Location = new System.Drawing.Point(4, 271);
            this.weekdayLabel5.Name = "weekdayLabel5";
            this.weekdayLabel5.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel5.TabIndex = 16;
            this.weekdayLabel5.Text = "Th";
            this.weekdayLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekdayLabel4
            // 
            this.weekdayLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel4.Location = new System.Drawing.Point(4, 211);
            this.weekdayLabel4.Name = "weekdayLabel4";
            this.weekdayLabel4.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel4.TabIndex = 15;
            this.weekdayLabel4.Text = "W";
            this.weekdayLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekdayLabel3
            // 
            this.weekdayLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel3.Location = new System.Drawing.Point(4, 151);
            this.weekdayLabel3.Name = "weekdayLabel3";
            this.weekdayLabel3.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel3.TabIndex = 14;
            this.weekdayLabel3.Text = "Tu";
            this.weekdayLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekdayLabel2
            // 
            this.weekdayLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel2.Location = new System.Drawing.Point(4, 91);
            this.weekdayLabel2.Name = "weekdayLabel2";
            this.weekdayLabel2.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel2.TabIndex = 13;
            this.weekdayLabel2.Text = "M";
            this.weekdayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel11
            // 
            this.timeLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel11.Location = new System.Drawing.Point(728, 1);
            this.timeLabel11.Name = "timeLabel11";
            this.timeLabel11.Size = new System.Drawing.Size(68, 29);
            this.timeLabel11.TabIndex = 12;
            this.timeLabel11.Text = "18:00";
            this.timeLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel10
            // 
            this.timeLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel10.Location = new System.Drawing.Point(658, 1);
            this.timeLabel10.Name = "timeLabel10";
            this.timeLabel10.Size = new System.Drawing.Size(63, 29);
            this.timeLabel10.TabIndex = 11;
            this.timeLabel10.Text = "17:00";
            this.timeLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel9
            // 
            this.timeLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel9.Location = new System.Drawing.Point(588, 1);
            this.timeLabel9.Name = "timeLabel9";
            this.timeLabel9.Size = new System.Drawing.Size(63, 29);
            this.timeLabel9.TabIndex = 10;
            this.timeLabel9.Text = "16:00";
            this.timeLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel8
            // 
            this.timeLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel8.Location = new System.Drawing.Point(518, 1);
            this.timeLabel8.Name = "timeLabel8";
            this.timeLabel8.Size = new System.Drawing.Size(63, 29);
            this.timeLabel8.TabIndex = 9;
            this.timeLabel8.Text = "15:00";
            this.timeLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel7
            // 
            this.timeLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel7.Location = new System.Drawing.Point(448, 1);
            this.timeLabel7.Name = "timeLabel7";
            this.timeLabel7.Size = new System.Drawing.Size(63, 29);
            this.timeLabel7.TabIndex = 8;
            this.timeLabel7.Text = "14:00";
            this.timeLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel6
            // 
            this.timeLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel6.Location = new System.Drawing.Point(378, 1);
            this.timeLabel6.Name = "timeLabel6";
            this.timeLabel6.Size = new System.Drawing.Size(63, 29);
            this.timeLabel6.TabIndex = 7;
            this.timeLabel6.Text = "13:00";
            this.timeLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel5
            // 
            this.timeLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel5.Location = new System.Drawing.Point(308, 1);
            this.timeLabel5.Name = "timeLabel5";
            this.timeLabel5.Size = new System.Drawing.Size(63, 29);
            this.timeLabel5.TabIndex = 6;
            this.timeLabel5.Text = "12:00";
            this.timeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel4
            // 
            this.timeLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel4.Location = new System.Drawing.Point(238, 1);
            this.timeLabel4.Name = "timeLabel4";
            this.timeLabel4.Size = new System.Drawing.Size(63, 29);
            this.timeLabel4.TabIndex = 5;
            this.timeLabel4.Text = "11:00";
            this.timeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel3
            // 
            this.timeLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel3.Location = new System.Drawing.Point(168, 1);
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(63, 29);
            this.timeLabel3.TabIndex = 4;
            this.timeLabel3.Text = "10:00";
            this.timeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel2
            // 
            this.timeLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel2.Location = new System.Drawing.Point(98, 1);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(63, 29);
            this.timeLabel2.TabIndex = 3;
            this.timeLabel2.Text = "9:00";
            this.timeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel1
            // 
            this.timeLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel1.Location = new System.Drawing.Point(28, 1);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(63, 29);
            this.timeLabel1.TabIndex = 2;
            this.timeLabel1.Text = "8:00";
            this.timeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weekdayLabel1
            // 
            this.weekdayLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayLabel1.Location = new System.Drawing.Point(4, 31);
            this.weekdayLabel1.Name = "weekdayLabel1";
            this.weekdayLabel1.Size = new System.Drawing.Size(17, 59);
            this.weekdayLabel1.TabIndex = 0;
            this.weekdayLabel1.Text = "Su";
            this.weekdayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "National Mehmet Funky Dance Party [IMPORTANT]";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 53);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(308, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 53);
            this.panel4.TabIndex = 19;
            // 
            // CalendarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.CalendarPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Button buttonLastWeek;
        private System.Windows.Forms.Button buttonNextWeek;
        private System.Windows.Forms.DateTimePicker calendarPanelDatePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timeLabel10;
        private System.Windows.Forms.Label timeLabel9;
        private System.Windows.Forms.Label timeLabel8;
        private System.Windows.Forms.Label timeLabel7;
        private System.Windows.Forms.Label timeLabel6;
        private System.Windows.Forms.Label timeLabel5;
        private System.Windows.Forms.Label timeLabel4;
        private System.Windows.Forms.Label timeLabel3;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Label weekdayLabel1;
        private System.Windows.Forms.Label timeLabel11;
        private System.Windows.Forms.Label weekdayLabel7;
        private System.Windows.Forms.Label weekdayLabel6;
        private System.Windows.Forms.Label weekdayLabel5;
        private System.Windows.Forms.Label weekdayLabel4;
        private System.Windows.Forms.Label weekdayLabel3;
        private System.Windows.Forms.Label weekdayLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
