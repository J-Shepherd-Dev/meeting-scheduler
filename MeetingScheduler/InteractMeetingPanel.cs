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

        private LayoutSuspensionSemaphore semaphore;
        private bool dontUpdateChecks = false;

        public InteractMeetingPanel()
        {
            InitializeComponent();
            semaphore = new LayoutSuspensionSemaphore(this);

            ToolTip initOnlyTooltip = new ToolTip();
            initOnlyTooltip.ToolTipTitle = "";
            initOnlyTooltip.SetToolTip(this.editBtn, "Only initiators can edit meetings");
            initOnlyTooltip.SetToolTip(this.viewRequestsBtn, "Only initiators can view requests");

            UpdatePanels(null, null);
        }

        public void UpdatePanels()
        {
            UpdatePanels(this._meeting, this._impersonator);
        }

        public void UpdatePanels(Meeting m, User impersonating)
        {
            dontUpdateChecks = true;

            using (var handle = semaphore.Acquire())
            {
                this._meeting = m;
                this._impersonator = impersonating;
                this._participant = this._meeting?.GetParticipant(impersonating);
                Logging.AddMessage($"Meeting set to {_meeting} and impersonating {impersonating}");

                // Update visibility based on user access and stance
                editBtn.Enabled = this._meeting != null && this._meeting.Initiator == impersonating;
                viewRequestsBtn.Enabled = editBtn.Enabled;
                attendNoBtn.Visible = attendYesBtn.Visible = attendLabel.Visible = (_participant != null);

                if (_participant != null)
                {
                    // If we've registered our attendance
                    attendYesBtn.BackColor = (_participant.hasGivenAttendance && !_participant.attending) ? Color.LightGray : Color.PaleGreen;
                    attendNoBtn.BackColor = (_participant.hasGivenAttendance && _participant.attending) ? Color.LightGray : Color.FromArgb(255, 192, 192);
                }

                // Update text attributes
                meetingTitleLbl.Text = this._meeting?.Name ?? "No Meeting Selected";
                meetingDescTB.Text = this._meeting?.Details ?? "No description provided...";
                dateTimeInfoLbl.Text = this._meeting == null ? "" : FormatDate(this._meeting.StartTime) + " to " + FormatHour(this._meeting.EndTime);
                dateTimeInfoLbl.Text += this?._meeting?.CurrentLocation == null ? "" : " @ " + this._meeting.CurrentLocation;
                dateTimeInfoLbl.Text += this._meeting != null && this._meeting.GuestSpeaker != null ? " - Guest speaker: " + this._meeting.GuestSpeaker : "";

                //if this user is not important or a guest speaker, hide/disable their location choices
                this.locationGB.Enabled = this._participant != null && this._participant.Attendance && this._participant.status != 0;
                this.locationGB.Visible = this._participant != null && this._participant.status != 0;
                //if the participant is not attending, hide their equipment requests
                this.equipmentGB.Enabled = this._participant != null && this._participant.Attendance;

                //update the info text panel above the participant list
                meetingInfoBox.Text = "";
                if (this._meeting != null)
                {
                    meetingInfoBox.Text = this._meeting.CapacityNeeded + " confirmed attendees. ";
                    if (this._meeting.PotentialLocations.Count == 1)
                    {
                        meetingInfoBox.Text += "Scheduled Location: " + this._meeting.CurrentLocation;
                    }
                    else
                    {
                        meetingInfoBox.Text += "Potential Locations: ";
                        for (int i = 0; i < this._meeting.PotentialLocations.Count; ++i)
                        {
                            meetingInfoBox.Text += (i > 0 ? "," : "");
                            meetingInfoBox.Text += this._meeting.PotentialLocations.ElementAt(i);
                        }
                    }
                }

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
                        equipmentCheckList.SetItemChecked(i,
                            this._participant.equipmentRequests.Contains(equipmentCheckList.Items[i])
                            );
                    }
                    for (int i = 0; i < this.locationCheckList.Items.Count; ++i)
                    {
                        locationCheckList.SetItemChecked(i,
                            this._participant.locationPreferences.Contains(locationCheckList.Items[i])
                            );
                    }
                }

                /*
                 * Message box alerts for user stories
                 */
                //if there is no location for this meeting, let the initiator know
                if (this._meeting != null && this._meeting.CurrentLocation == null)
                {
                    if (this._meeting.Initiator == this._impersonator)
                    {
                        MessageBox.Show("There is no available location for " + this._meeting + ". Please consider editing the meeting to move it to a different slot.");
                    }
                    else {
                        //heads up, meeting will move or be cancelled.
                        MessageBox.Show(this._meeting+" currently has no location. This means in may be moved or even cancelled."+(this._meeting.GetParticipant(this._impersonator)?.equipmentRequests.Count<1 ? "" : " Please considering reducing your equipment requests."));
                    }
                }
                //user story 1 - acceptance criteria 1 - no message box
                //user story 1 - acceptance criteria 3 - no message box
                //user story 1 - acceptance criteria 2 & 4
                if (this._meeting != null && this._meeting.UnavailableEquipment.Count > 1)
                {
                    if (this._meeting.Initiator == this._impersonator)
                    {
                        string unavailEquip = "";
                        foreach (Equipment equip in this._meeting.UnavailableEquipment)
                        {
                            unavailEquip += "\n" + equip;
                        }
                        MessageBox.Show("The equipment below has been requested but is unavailable. Please consider rearranging the meeting to accomodate these requests.\n" + unavailEquip);
                    }
                }

                //user story 2
                if (this._meeting != null && this._meeting.HasBeenMoved)
                {
                    MessageBox.Show("This meeting has been moved from its original time. You may need to recheck your attendance.", "Meeting update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //user story 4
                if (this._meeting != null && !this._meeting.canGoAhead)
                {
                    MessageBox.Show("A guest speaker cannot attend " + this._meeting + ". " + (this._meeting.Initiator == this._impersonator ? " Please edit the meeting." : "Be prepared for it to be re-arranged or cancelled."), "Meeting update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            dontUpdateChecks = false;
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

                UpdatePanels();
            }
        }

        private void attendNoBtn_Click(object sender, EventArgs e)
        {
            if (_participant != null)
            {
                _participant.hasGivenAttendance = true;
                _participant.attending = false;

                UpdatePanels();
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

        private void equipmentCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (dontUpdateChecks) return;

            if (this._participant != null)
            {

                if (e.NewValue == CheckState.Checked)
                {
                    this._participant.equipmentRequests.Add((Equipment)(sender as CheckedListBox).Items[e.Index]);

                    Location previousLocation = this._meeting.CurrentLocation;
                    this._meeting.CurrentLocation = this._meeting.ProvisionalLocation;

                    // Can't satisfy this equipment
                    if (this._meeting.CurrentLocation == null)
                    {
                        // List of meetings that, if moved, would give us a suitable location for this meeting.
                        List<Meeting> wouldFreeSlotForUs = new List<Meeting>();
                        List<Meeting> lowerImportance = new List<Meeting>();

                        foreach (Meeting m in this._meeting.IntersectingMeetings)
                        {
                            if (this._meeting.PotentialLocations.Contains(m.CurrentLocation))
                            {
                                wouldFreeSlotForUs.Add(m);
                            }
                        }

                        foreach (Meeting m in wouldFreeSlotForUs)
                        {
                            if (this._meeting.ComparePriority(m) < 0)
                            {
                                lowerImportance.Add(m);
                            }
                        }

                        if (lowerImportance.Count == 0)
                        {
                            string meetingsText = "";
                            foreach (Meeting m in wouldFreeSlotForUs)
                                if (!lowerImportance.Contains(m))
                                    meetingsText += $"- {m} ({m.CurrentLocation})\n";

                            MessageBox.Show($"There is no available location that satisfies this equipment request because all rooms are taken by existing, higher priority meetings:\n\n{meetingsText}", "Meeting conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Revert change
                            this._participant.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);
                            this._meeting.CurrentLocation = previousLocation;
                        }
                        else
                        {
                            string listOfMeetings = "";
                            foreach (Meeting m in lowerImportance)
                            {
                                listOfMeetings += $"- {m} ({m.CurrentLocation})\n";
                            }

                            DialogResult result = MessageBox.Show($"There is no available location that satisfies this equipment request because all rooms are taken by existing meetings, but there are lower importance meetings that, if moved, would allow the requirements to be met::\n\n{listOfMeetings}\nYou can choose to move these meetings out of their room to free up resources for your meeting.\n\nDo you want to move the conflicting meetings?", "Meeting conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                foreach (Meeting m in lowerImportance)
                                {
                                    m.CurrentLocation = null;
                                }

                                this._meeting.CurrentLocation = this._meeting.ProvisionalLocation;

                                foreach (Meeting m in lowerImportance)
                                {
                                    m.CurrentLocation = m.ProvisionalLocation;
                                }
                            }
                            else
                            {
                                // Revert change
                                this._participant.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);
                                this._meeting.CurrentLocation = previousLocation;
                            }
                        }
                    } else if (this._meeting.MeetingsUsingOurPortableEquipment.Count > 0)
                    {
                        // List of meetings that, if moved, would give us a suitable location for this meeting.
                        List<Meeting> wouldFreeSlotForUs = this._meeting.MeetingsUsingOurPortableEquipment.ToList();
                        List<Meeting> lowerImportance = new List<Meeting>();

                        foreach (Meeting m in wouldFreeSlotForUs)
                        {
                            if (this._meeting.ComparePriority(m) < 0)
                            {
                                lowerImportance.Add(m);
                            }
                        }

                        if (lowerImportance.Count == 0)
                        {
                            string meetingsText = "";
                            foreach (Meeting m in wouldFreeSlotForUs)
                                if (!lowerImportance.Contains(m))
                                    meetingsText += $"- {m} ({m.CurrentLocation})\n";

                            MessageBox.Show($"This equipment request cannot be satisfied because limited portable equipment is taken up by other meetings:\n\n{meetingsText}", "Meeting conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Revert change
                            this._participant.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);
                        }
                        else
                        {
                            string listOfMeetings = "";
                            foreach (Meeting m in lowerImportance)
                            {
                                listOfMeetings += $"- {m} ({m.CurrentLocation})\n";
                            }

                            DialogResult result = MessageBox.Show($"This equipment request cannot be satisfied because limited portable equipment is taken up by other meetings, but there are lower importance meetings that could be changed to free up equipment:\n\n{listOfMeetings}\nYou can choose to change the equipment requirements of this meeting to free up resources for your meeting.\n\nDo you want to edit the conflicting meetings?", "Meeting conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                foreach (Meeting m in lowerImportance)
                                {
                                    foreach (Participant p in m.Participants)
                                    {
                                        p.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);
                                    }
                                }
                            }
                            else
                            {
                                // Revert change
                                this._participant.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);
                            }
                        }
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                    this._participant.equipmentRequests.Remove((Equipment)(sender as CheckedListBox).Items[e.Index]);

                UpdatePanels();
            }
        }

        private void locationCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (dontUpdateChecks) return;

            if (this._participant != null)
            {
                if (e.NewValue == CheckState.Checked)
                    this._participant.locationPreferences.Add((Location)(sender as CheckedListBox).Items[e.Index]);
                else if (e.NewValue == CheckState.Unchecked)
                    this._participant.locationPreferences.Remove((Location)(sender as CheckedListBox).Items[e.Index]);

                // Location changes are easy, a null transition should never be possible because no location possibilities are removed due to a location preference.
                this._meeting.CurrentLocation = this._meeting.ProvisionalLocation;

                UpdatePanels();
            }
        }
    }
}
