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
            dtEnd.Value = selectedDate.AddHours(1);

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
                if (chkBGroupMeeting.Checked)
                {
                    var group = new GroupMeeting
                    {
                        Title = title,
                        Description = "",
                        Start = start,
                        End = end,
                        UserId = currentUser.Id,
                        Participants = new List<User> { db.Users.Find(currentUser.Id) }
                    };
                    db.GroupMeetings.Add(group);
                }
                var conflict = bus.GetConflictingPersonalEvent(currentUser.Id, start, end);
                var newEvent = new PersonalEvent
                {
                    Title = title,
                    Location = location,
                    Start = start,
                    End = end,
                    UserId = currentUser.Id
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
                        TimeSpan offset = GetOffsetFromString(item.ToString());
                        var reminder = new Reminder
                        {
                            NotifyAt = start.Subtract(offset),
       
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

        private TimeSpan GetOffsetFromString(string item)
        {
            switch (item.Trim())
            {
                case "10 phút": return TimeSpan.FromMinutes(10);
                case "30 phút": return TimeSpan.FromMinutes(30);
                case "1 giờ": return TimeSpan.FromHours(1);
                case "1 ngày": return TimeSpan.FromDays(1);
                default: return TimeSpan.FromMinutes(0);
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
            // Nếu thời gian bắt đầu mới lớn hơn thời gian kết thúc → cập nhật lại dtEnd
            if (dtStart.Value >= dtEnd.Value)
            {
                dtEnd.Value = dtStart.Value.AddHours(1); // mặc định gợi ý sau 1 giờ
            }
        }
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtEnd.Value <= dtStart.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.");
                dtEnd.Value = dtStart.Value.AddHours(1);
            }
        }

    }
}
