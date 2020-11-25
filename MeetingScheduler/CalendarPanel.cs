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
            }
        }

        public CalendarPanel()
        {
            InitializeComponent();
        }

        private void CalendarPanel_Load(object sender, EventArgs e)
        {
            CurrentWeek = DateTime.Today;
        }

        private DateTime GetWeekStart(DateTime date)
        {
            // The amount of days until the last Sunday, as a TimeSpan
            TimeSpan untilBeginning = new TimeSpan((int)date.DayOfWeek, 0, 0, 0);

            return date - untilBeginning;
        }

        private string FormatDate(DateTime date)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            return date.ToString("ddd d MMM yyyy", culture);
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
            Point mouse = PointToClient(MousePosition);

            // The left header has a relative width of 1
            // Each of the 11 time slots has a relative width of 3
            // This rounds into column number, starting from 0
            float clickX = (mouse.X * (11.5f / Width)) + 0.6666f;

            // The top header has a relative height of 1
            // Each of the 7 week days has a relative height of 2
            // This rounds into the row number, starting from 0
            float clickY = (mouse.Y * (8.6666f / Height)) - 0.5f;

            //MessageBox.Show($"{clickX}, {clickY}");
            if (clickX > 0.0f && clickY > 0.0f)
            {
                SuspendLayout();
                tableLayoutPanel1.SetRow(panel4, (int)clickY);
                tableLayoutPanel1.SetColumn(panel4, (int)clickX);
                ResumeLayout();
            }
        }
    }
}
