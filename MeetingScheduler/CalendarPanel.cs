using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class CalendarPanel : UserControl
    {
        private DateTime _currentWeek;

        public DateTime CurrentWeek
        {
            get
            {
                return _currentWeek;
            }
            set
            {
                _currentWeek = GetWeekStart(value);

                Logging.AddMessage($"Current week set to {_currentWeek}");

                // 6 days to display 7 days including current day
                TimeSpan oneWeek = new TimeSpan(6, 0, 0, 0);

                // Technically speaking usually you'd just want to do string interpolation e.g.
                // $"{_currentWeek:ddd d MMM yyyy}" but then we can't set locale
                labelWeek.Text = $"{FormatDate(_currentWeek)} - {FormatDate(_currentWeek + oneWeek)}";

                DrawMeetings();
            }
        }

        private Meeting _editedMeeting = null;

        public Meeting editedMeeting
        {
            get
            {
                return _editedMeeting;
            }
            set
            {
                _editedMeeting = value;

                DrawMeetings();
            }
        }

        private Meeting[] _meetings = new Meeting[0];

        public Meeting[] meetings
        {
            get
            {
                return _meetings;
            }
            set
            {
                _meetings = value;

                DrawMeetings();
            }
        }

        public List<Panel> meetingPanels = new List<Panel>();

        public CalendarPanel()
        {
            InitializeComponent();
        }

        private void CalendarPanel_Load(object sender, EventArgs e)
        {
            CurrentWeek = DateTime.Today;

            // Make a meeting
            meetings = new Meeting[] {};

            DrawMeetings();
        }

        private DateTime GetWeekStart(DateTime date)
        {
            // The amount of days until the last Sunday, as a TimeSpan
            TimeSpan untilBeginning = new TimeSpan((int)date.DayOfWeek, 0, 0, 0);

            return (date - untilBeginning).Date;
        }

        private string FormatDate(DateTime date)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            return date.ToString("ddd d MMM yyyy", culture);
        }

        private void DrawMeetings()
        {
            // If panels for meetings already exist, remove them
            foreach (Panel panel in meetingPanels)
            {
                panel.Dispose();
            }

            // Clear collection
            meetingPanels.Clear();

            // Recreate panels

            if (editedMeeting != null)
                meetingPanels.Add(CreatePanelFromMeeting(editedMeeting, Color.DarkGray));

            foreach (Meeting meeting in meetings)
            {
                // Ignore meetings not in this week
                if (meeting.Time < _currentWeek || meeting.Time > (_currentWeek + new TimeSpan(7, 0, 0, 0)))
                    continue;

                // Ignore meetings not between 8am and 7pm
                if (meeting.Time.Hour < 8 || meeting.Time.Hour > 18)
                    continue;

                // Push panel
                meetingPanels.Add(CreatePanelFromMeeting(meeting));
            }
        }

        private Panel CreatePanelFromMeeting(Meeting meeting, Color? color = null)
        {
            // Make a panel
            Panel panel = new Panel();
            tableLayoutPanel1.Controls.Add(panel, meeting.Time.Hour - 7, (int)meeting.Time.DayOfWeek + 1);  // Associate it with the table
            tableLayoutPanel1.SetColumnSpan(panel, meeting.Length);
            panel.Dock = DockStyle.Fill;  // Dock the panel
            panel.BackColor = Color.White;

            // Create the accent panel
            Panel colorTab = new Panel();
            panel.Controls.Add(colorTab);
            colorTab.Dock = DockStyle.Left;
            colorTab.Width = 10;
            colorTab.Margin = new Padding(0);
            colorTab.BackColor = color ?? Color.Red;

            // Meeting label
            Label label = new Label();
            panel.Controls.Add(label);
            label.AutoSize = false;
            label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label.Text = meeting.Name;
            label.Location = new Point(13, 3);
            label.Size = new Size(panel.Width - 15, 50);
            label.Margin = new Padding(3);
            label.TabIndex = 1;

            return panel;
        }

        private void buttonLastWeek_Click(object sender, EventArgs e)
        {
            // Go back 7 days
            CurrentWeek -= new TimeSpan(7, 0, 0, 0);
        }

        private void buttonNextWeek_Click(object sender, EventArgs e)
        {
            // Advance 7 days
            CurrentWeek += new TimeSpan(7, 0, 0, 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CurrentWeek = (sender as DateTimePicker).Value;
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouse = tableLayoutPanel1.PointToClient(Cursor.Position);

            // We now have to figure out the row and column indices
            int[] widths = tableLayoutPanel1.GetColumnWidths();
            int[] heights = tableLayoutPanel1.GetRowHeights();
            int currentWidth = tableLayoutPanel1.Width;
            int currentHeight = tableLayoutPanel1.Height;

            // Traverse column widths
            int column;
            for (column = widths.Length - 1; column >= 0 && mouse.X < currentWidth; column--)
                currentWidth -= widths[column];

            // Traverse row widths
            int row;
            for (row = heights.Length - 1; row >= 0 && mouse.Y < currentHeight; row--)
                currentHeight -= heights[row];

            DateTime time = CurrentWeek + new TimeSpan(row, column + 8, 0, 0);

            // Move edited meeting
            if (editedMeeting != null)
            {
                editedMeeting.Time = time;
                Logging.AddMessage($"Moved meeting {editedMeeting} to {time}");
            } else
            {
                Logging.AddMessage($"Selected time {time} but there is no meeting to move");
            }

            DrawMeetings();
        }
    }
}
