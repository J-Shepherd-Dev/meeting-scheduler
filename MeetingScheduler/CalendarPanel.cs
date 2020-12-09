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
        public event EventHandler Changed;

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

        public LayoutSuspensionSemaphore semaphore;

        public CalendarPanel()
        {
            InitializeComponent();

            semaphore = new LayoutSuspensionSemaphore(this);
        }

        public LayoutSuspensionSemaphore.Handle Suspend()
        {
            return semaphore.Acquire();
        }

        private void CalendarPanel_Load(object sender, EventArgs e)
        {
            CurrentWeek = DateTime.Today;

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
            using (var handle = Suspend())
            {
                // Clear tooltips
                toolTip1.RemoveAll();

                // If panels for meetings already exist, remove them
                foreach (Panel panel in meetingPanels)
                {
                    // Unbind click events
                    foreach (Control c in panel.Controls)
                        c.MouseClick -= tableLayoutPanel1_MouseClick;

                    panel.Dispose();
                }

                // Clear collection
                meetingPanels.Clear();

                // Recreate panels
                // Create a hashset for each of the available slots
                List<Meeting>[,] slots = new List<Meeting>[7, 11];
                int editedConflicts = 0;


                foreach (Meeting meeting in meetings)
                {
                    // Ignore a meeting if it's the edited meeting
                    if (meeting == editedMeeting)
                        continue;

                    // Ignore meetings not in this week
                    if (meeting.StartTime < _currentWeek || meeting.StartTime > (_currentWeek + new TimeSpan(7, 0, 0, 0)))
                        continue;

                    // Ignore meetings not between 8am and 7pm
                    if (meeting.StartTime.Hour < 8 || meeting.StartTime.Hour > 18)
                        continue;

                    // If the currently edited meeting conflicts, record it
                    if (_editedMeeting != null && meeting.Intersects(_editedMeeting))
                        editedConflicts++;

                    // Create an entry for each grid space this meeting takes up
                    for (int column = meeting.Column; column < meeting.Column + meeting.Length; ++column)
                    {
                        if (slots[meeting.Row - 1, column - 1] is null)
                            slots[meeting.Row - 1, column - 1] = new List<Meeting>();

                        slots[meeting.Row - 1, column - 1].Add(meeting);
                    }
                }

                // Now operate on each row and column to create the panels
                for (int row = 0; row < 7; ++row)
                {
                    for (int column = 0; column < 11; ++column)
                    {
                        if (slots[row, column] is null) continue;

                        // Skip slots in the edited range because we want the edited meeting to always have display priority
                        bool isEditedRange = (_editedMeeting != null) && (_editedMeeting.Row - 1 == row && column >= _editedMeeting.Column - 1 && column < _editedMeeting.Column - 1 + _editedMeeting.Length);
                        if (isEditedRange) continue;

                        var entry = slots[row, column];

                        int rootColumn = column;
                        int length = 0;
                        string name = "";
                        if (entry.Count == 1)
                        {
                            name = $"{entry[0].Name}\n{entry[0].CurrentLocation}";
                        }
                        else
                        {
                            name = $"{entry.Count} meetings:";
                            foreach(Meeting m in entry)
                            {
                                name += $"\n{m}";
                            }
                        }
                        Color backColor = entry.Count == 1 ? Color.White : Color.LightBlue;

                        // Now attempt to advance
                        while (column < 11 && !isEditedRange && slots[row, column] != null && slots[row, column].SequenceEqual(entry))
                        {
                            ++column;
                            ++length;
                            isEditedRange = (_editedMeeting != null) && (_editedMeeting.Row - 1 == row && column >= _editedMeeting.Column - 1 && column < _editedMeeting.Column - 1 + _editedMeeting.Length);
                        }

                        // Undo extraneous advance when breaking out of the loop
                        --column;

                        meetingPanels.Add(CreateMeetingPanel(
                            rootColumn + 1, row + 1, length,
                            name,
                            backColor, entry.Count == 1 ? Color.Blue : (Color?)null
                        ));
                    }
                }

                if (editedMeeting != null)
                    meetingPanels.Add(CreateMeetingPanel(
                        editedMeeting.Column, editedMeeting.Row, editedMeeting.Length,
                        editedConflicts > 0 ? (editedConflicts == 1 ? $"[1 CONFLICT] {editedMeeting.Name}" : $"[{editedConflicts} CONFLICTS] {editedMeeting.Name}") : editedMeeting.Name,
                        editedConflicts > 0 ? Color.Red : Color.White, Color.DarkGray
                    ));
            }
        }

        private Panel CreateMeetingPanel(int column, int row, int length, string name, Color? backColor = null, Color? color = null)
        {
            // Make a panel
            Panel panel = new Panel();
            tableLayoutPanel1.Controls.Add(panel, column, row);  // Associate it with the table
            tableLayoutPanel1.SetColumnSpan(panel, length);
            panel.Dock = DockStyle.Fill;  // Dock the panel
            panel.BackColor = backColor ?? Color.White;

            // If a color has not been specified, do not create an accent panel.
            if (color != null)
            {
                // Create the accent panel
                Panel colorTab = new Panel();
                panel.Controls.Add(colorTab);
                colorTab.Dock = DockStyle.Left;
                colorTab.Width = 10;
                colorTab.Margin = new Padding(0);
                colorTab.BackColor = color ?? Color.Red;
            }

            // Meeting label
            Label label = new Label();
            panel.Controls.Add(label);
            label.AutoSize = false;
            label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label.Text = name;
            toolTip1.SetToolTip(label, name);
            label.Location = new Point(color == null ? 3 : 13, 3);
            label.Size = new Size(panel.Width - 15, 50);
            label.Margin = new Padding(3);
            label.TabIndex = 1;

            // Treat clicks on this panel same as on the main table
            foreach (Control c in panel.Controls)
                c.MouseClick += tableLayoutPanel1_MouseClick;

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
                editedMeeting.StartTime = time;
                Changed?.Invoke(null, new EventArgs());
                Logging.AddMessage($"Moved meeting {editedMeeting} to {time}");
            } else
            {
                Logging.AddMessage($"Selected time {time} but there is no meeting to move");
            }

            DrawMeetings();
        }

        private void labelWeek_Click(object sender, EventArgs e)
        {

        }
    }
}
