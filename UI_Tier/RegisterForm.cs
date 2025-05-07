using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string phone = txtPhoneNumber.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(pass)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            using (var db = new CalendarDbContext())
            {
                var exist = db.Users.FirstOrDefault(u=> u.UserName == username||u.PhoneNumber==phone);
                if (exist != null)
                {
                    MessageBox.Show("Tên hoặc số điện thoại đã tồn tại", "Trùng tài khoản!");
                    return;
                }

                var user = new User
                {
                    UserName = username,
                    PhoneNumber = phone,
                    Password = pass
                };
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Tên hoặc số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Đăng ký thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (var loginForm  = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {

                    Application.Run(new MainForm(loginForm.AuthenticatedUser));
                }
                else { this.Show(); }
            }
            this.Close();
        }
    }
}
