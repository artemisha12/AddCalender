using Bus_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    public partial class MainForm : Form
    {
        private DateTime currentMonth = DateTime.Now;
        private DateTime currenntSelectedDate = DateTime.Today;
       
        private User currentUser;
        private CalendarBus bus = new CalendarBus();
        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadCalender(DateTime.Now);
            lbUsername.Text= user.UserName;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bus.Dispose(); 

             var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
             if (result == DialogResult.No) e.Cancel = true;
        }
        private void LoadCalender(DateTime month)
        {
            lbMonth.Text = "Tháng" + month.ToString("MM/yyyy");
            var eventDates = bus.GetEventDatesInMonth(currentUser.Id, month);

            for (int i = tbLayoutCalender.Controls.Count - 1; i >= 0; i--)
            {
                var control = tbLayoutCalender.Controls[i];
                var position = tbLayoutCalender.GetRow(control);

                if (position != 0) // != dòng tiêu đề
                {
                    tbLayoutCalender.Controls.RemoveAt(i);
                }
            }
            DateTime firstDayOfMonth = new DateTime(month.Year,month.Month,1);

            int startDayOfWeek = ((int )firstDayOfMonth.DayOfWeek==0)? 7 : (int) firstDayOfMonth.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);

            for (int day =1;day <= daysInMonth;day++) 
                {
                    var btnDay = new Button();
                    btnDay.Text = day.ToString();
                    btnDay.Dock= DockStyle.Fill;
                    DateTime currentDate = new DateTime(month.Year, month.Month, day);
                    btnDay.Tag = currentDate;
                    btnDay.Click += DayButton_Click;
                    int cellIndex = (startDayOfWeek - 1) + (day - 1);
                    int column = cellIndex % 7;
                    int row = cellIndex / 7 + 1;
                    tbLayoutCalender.Controls.Add(btnDay,column,row);
                if (eventDates.Contains(currentDate.Date))
                {
                    btnDay.BackColor = Color.LightPink; 
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
           
            using (var addForm = new AddNewForm(currentUser, currenntSelectedDate))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCalender(currentMonth);
                    DayButton_Click(new Button { Tag = currenntSelectedDate }, EventArgs.Empty);
                }
            }    
        }
        private void DayButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) { return; } // Fix: Corrected the null check condition    

            currenntSelectedDate = (DateTime)clickedButton.Tag;

            lbDate.Text = currenntSelectedDate.ToString("dd/MM/yyyy");

            var events = bus.GetEventsByDate(currentUser.Id, currenntSelectedDate);

            lstEvent.Items.Clear();
            foreach (var ev in events)
            {
                lstEvent.Items.Add($" ({ev.Type}): {ev.Title} Ngày {ev.Start:dd/MM} : {ev.Start:HH:mm} - Ngày {ev.End:dd/MM} : {ev.End:HH:mm}");
            }
        }
            
   
        

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            LoadCalender(currentMonth);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentMonth= currentMonth.AddMonths(1);
            LoadCalender(currentMonth);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    
                    var newMain = new MainForm(loginForm.AuthenticatedUser);
                    newMain.ShowDialog();
                }
            }
            bus.SaveAllChanges();
            this.Close();
        }

        private void lstEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
