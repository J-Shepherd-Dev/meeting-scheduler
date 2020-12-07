using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MeetingScheduler
{
    public partial class InteractMeetingPanel : UserControl
    {
        private Meeting _meeting;
        private User _impersonator;
        private Participant _participant;  // Participant version of _impersonator

        public InteractMeetingPanel()
        {
            InitializeComponent();
            UpdatePanels(null, null);
        }

        public void UpdatePanels(Meeting m, User impersonating)
        {
            this._meeting = m;
            this._impersonator = impersonating;
            this._participant = this._meeting?.GetParticipant(impersonating);
            Logging.AddMessage($"Meeting set to {_meeting} and impersonating {impersonating}");

            // Update visibility based on user access and stance
            editBtn.Enabled = this._meeting != null && this._meeting.Initiator == impersonating;
            viewRequestsBtn.Enabled = editBtn.Enabled;
            attendNoBtn.Visible = attendYesBtn.Visible = attendLabel.Visible = (_participant != null);

            if (_participant != null) {
                // If we've registered our attendance
                attendYesBtn.BackColor = (_participant.hasGivenAttendance && !_participant.attending) ? Color.LightGray : Color.PaleGreen;
                attendNoBtn.BackColor = (_participant.hasGivenAttendance && _participant.attending) ? Color.LightGray : Color.FromArgb(255, 192, 192);
            }

            // Update text attributes
            meetingTitleLbl.Text = this._meeting?.Name ?? "No Meeting Selected";
            meetingDescTB.Text = this._meeting?.Details ?? "No description provided...";
            dateTimeInfoLbl.Text = this._meeting==null ? "" : FormatDate(this._meeting.StartTime) + " to " + FormatHour(this._meeting.EndTime);
            dateTimeInfoLbl.Text += this._meeting != null && this._meeting.GuestSpeaker!=null ? " - Guest speaker: "+ this._meeting.GuestSpeaker : "";

            //if this user is not important or a guest speaker, hide/disable their location choices
            this.locationGB.Enabled = this._participant!=null && this._participant.Attendance && this._participant.status != 0;
            this.locationGB.Visible = this._participant != null && this._participant.status != 0;
            //if the participant is not attending, hide their equipment requests
            this.equipmentGB.Enabled = this._participant != null && this._participant.Attendance;


            // Show the participants for this meeting in the flow panel
            participantFlowPanel.Controls.Clear();
            if (this._meeting != null && this._meeting.Participants.Count > 0)
            {
                foreach (Participant p in this._meeting.Participants)
                {
                    ParticipantPanel pPanel = new ParticipantPanel(this._meeting, p, 0, null, this._impersonator);
                    participantFlowPanel.Controls.Add(pPanel);
                }
            }

            //load options into the equipment list and location list
            this.equipmentCheckList.Items.Clear();
            this.locationCheckList.Items.Clear();
            this.equipmentCheckList.Items.AddRange(AllEquipment.Equipment.ToArray());
            this.locationCheckList.Items.AddRange(AllLocations.Locations.ToArray());
            if (this._participant != null)
            {
                for (int i = 0; i < this.equipmentCheckList.Items.Count; ++i)
                {
                    if (this._participant.equipmentRequests.Contains(equipmentCheckList.Items[i]))
                    {
                        equipmentCheckList.SetItemChecked(i, true);
                    }
                }
                for (int i = 0; i < this.locationCheckList.Items.Count; ++i)
                {
                    if (this._participant.locationPreferences.Contains(locationCheckList.Items[i]))
                    {
                        locationCheckList.SetItemChecked(i, true);
                    }
                }
            }


        }

        private string FormatDate(DateTime date)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            return date.ToString("ddd d MMM HH:mm", culture);
        }

        private string FormatHour(DateTime date)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            return date.ToString("HH:mm", culture);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this._meeting != null)
            {
                CreateMeeting cM = new CreateMeeting(this._meeting);
                cM.Show();
            }
        }

        private void attendYesBtn_Click(object sender, EventArgs e)
        {
            if (_participant != null)
            {
                _participant.hasGivenAttendance = true;
                _participant.attending = true;

                UpdatePanels(this._meeting, this._impersonator);
            }
        }

        private void attendNoBtn_Click(object sender, EventArgs e)
        {
            if (_participant != null)
            {
                _participant.hasGivenAttendance = true;
                _participant.attending = false;

                UpdatePanels(this._meeting, this._impersonator);
            }
        }

        private void locationCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._participant != null)
            {
                CheckedListBox.CheckedItemCollection checkedItems = (sender as CheckedListBox).CheckedItems;
                this._participant.locationPreferences.Clear();
                foreach (Object loc in checkedItems)
                {
                    this._participant.locationPreferences.Add((Location)loc);
                }
            }
        }

        private void equipmentCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._participant != null)
            {
                CheckedListBox.CheckedItemCollection checkedItems = (sender as CheckedListBox).CheckedItems;
                this._participant.equipmentRequests.Clear();
                foreach (Object equip in checkedItems)
                {
                    this._participant.equipmentRequests.Add((Equipment)equip);
                }
            }
        }

        private void dateTimeInfoLbl_Click(object sender, EventArgs e)
        {

        }

        private void viewRequestsBtn_Click(object sender, EventArgs e)
        {

            string equipMsg = "Equipment requested:\n";
            string locMsg = "\nLocations preferred:\n";
            if (this._meeting.EquipmentRequests.Count > 0)
            {
                foreach (Equipment equip in this._meeting.EquipmentRequests)
                {
                    equipMsg += equip + "\n";
                }
            }
            else
            {
                equipMsg += "There are no equipment requests\n";
            }
            if (this._meeting.LocationPreferences.Count > 0)
            {
                foreach (Location loc in this._meeting.LocationPreferences)
            {
                locMsg += loc + "\n";
            }
            }
            else
            {
                locMsg += "There are no location requests\n";
            }
            DialogResult requestDialog = MessageBox.Show(equipMsg + locMsg, "Indications made for " + this._meeting, MessageBoxButtons.OK);
            //we don't care about the result so nothing else happens
        }
    }
}
