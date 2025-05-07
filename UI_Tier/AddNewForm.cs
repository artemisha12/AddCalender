using Bus_Tier;
using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    public partial class AddNewForm : Form
    {
        User currentUser;
        DateTime selectedDate;
        CalendarBus bus = new CalendarBus();
        public AddNewForm(User user, DateTime dateSelected)
        {
            InitializeComponent();
            currentUser = user;
            this.selectedDate = dateSelected;
            

        }
        private void AddNewForm_Load(object sender, EventArgs e)
        {
            dtStart.Value = selectedDate;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string location = txtLocation.Text;
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.");
                return;
            }
            if (end <= start)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.");
                return;
            }
            TimeSpan newDuration = end - start;
            using (var db = new CalendarDbContext())
            {
                var conflict = bus.GetConflictingPersonalEvent(currentUser.Id, start, end);
                var newEvent = new PersonalEvent
                {
                    Title = title,
                    Location = location,
                    Start = start,
                    End = end,
                    UserId = currentUser.Id,
                    
                };
                if (conflict != null)
                {
                    var msg = $"Sự kiện cũ:\n- {conflict.Title}\n- {conflict.Start:HH:mm} → {conflict.End:HH:mm}";
                    var result = MessageBox.Show(
                        $"⚠ Trùng lịch với:\n{msg}\n\nBạn có muốn thay thế không?",
                        "Xung đột lịch trình",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    
                    if (result == DialogResult.Yes)
                    {
                        
                            db.PersonalEvents.Remove(db.PersonalEvents.Find(conflict.Id));
                        
                        db.PersonalEvents.Add(newEvent);
                        db.SaveChanges();
                        
                    }
                    else
                    {
                        var matchedGroup = bus.GetMatchingGroupMeeting(currentUser.Id, title, newDuration);

                        if (matchedGroup != null)
                        {
                            var result2 = MessageBox.Show(
                                $"⚠ Có một cuộc họp nhóm trùng tên và thời lượng.\nBạn có muốn tham gia thay vì tạo mới không?",
                                "Tham gia họp nhóm?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (result2 == DialogResult.Yes) // ✅ Dùng đúng biến result2
                            {
                                var groupToJoin = db.GroupMeetings.Find(matchedGroup.Id);
                                var user = db.Users.Find(currentUser.Id);
                                groupToJoin.Participants.Add(user);
                                db.SaveChanges();

                                MessageBox.Show("✅ Bạn đã được thêm vào cuộc họp nhóm.");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                return;
                            }
                        }
                        return;
                    }
                }
                else { db.PersonalEvents.Add(newEvent); }
                

                if (chkBoxRemind.Checked)
                {
                    
                    
                    foreach (var item in chLstRepeatDays.CheckedItems)
                    {
                        DayOfWeek? day = ConvertToDayOfWeek (item.ToString());
                        var reminder = new Reminder
                        {
                            NotifyAt = dTReapeat.Value,
                            DayOfWeek = day,
                            PersonalEvent = newEvent
                        };
                        db.Reminders.Add(reminder);
                    }
                   
                   
                }
                db.SaveChanges();
                MessageBox.Show("Đã thêm sự kiện thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private DayOfWeek? ConvertToDayOfWeek(String item)
        {
            

            switch (item.Trim())
            {
                case "Thứ 2": return DayOfWeek.Monday;
                case "Thứ 3": return DayOfWeek.Tuesday;
                case "Thứ 4": return DayOfWeek.Wednesday;
                case "Thứ 5": return DayOfWeek.Thursday;
                case "Thứ 6": return DayOfWeek.Friday;
                case "Thứ 7": return DayOfWeek.Saturday;
                case "Chủ nhật": return DayOfWeek.Sunday;
                default: return null;
            }
        }

       

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxRemind_CheckedChanged(object sender, EventArgs e)
        {
            plRemind.Visible = chkBoxRemind.Checked;
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
