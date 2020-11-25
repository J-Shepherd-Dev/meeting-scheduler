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
                // 6 days to display 7 days including current day
                TimeSpan oneWeek = new TimeSpan(6, 0, 0, 0);

                // Technically speaking usually you'd just want to do string interpolation e.g.
                // $"{_currentWeek:ddd d MMM yyyy}" but then we can't set locale
                labelWeek.Text = $"{FormatDate(_currentWeek)} - {FormatDate(_currentWeek + oneWeek)}";

                DrawMeetings();
            }
        }

        public Meeting[] meetings = new Meeting[0];
        public List<Panel> meetingPanels = new List<Panel>();

        public CalendarPanel()
        {
            InitializeComponent();
        }

        private void CalendarPanel_Load(object sender, EventArgs e)
        {
            CurrentWeek = DateTime.Today;

            // Make a meeting
            meetings = new Meeting[]
            {
                new Meeting(
                    "National Mehmet Funky Dance Party",
                    CurrentWeek + new TimeSpan(
                        2,  // Tuesday
                        12, 0, 0  // At 12 pm
                    ),
                    2
                )
            };

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
            foreach (Meeting meeting in meetings)
            {
                // Ignore meetings not in this week
                if (meeting.Time < _currentWeek || meeting.Time > (_currentWeek + new TimeSpan(7, 0, 0, 0)))
                    continue;

                // Ignore meetings not between 8am and 7pm
                if (meeting.Time.Hour < 8 || meeting.Time.Hour > 18)
                    continue;

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
                colorTab.BackColor = Color.Red;

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

                // Push panel
                meetingPanels.Add(panel);
            }
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

            // Move Mehmet dance party
            meetings[0].Time = CurrentWeek + new TimeSpan(row, column + 8, 0, 0);

            DrawMeetings();
        }
    }
}
