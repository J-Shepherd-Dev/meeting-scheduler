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
            this.CurrentWeek = (sender as DateTimePicker).Value;
        }
    }
}
