using Bus_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    public partial class LoginForm : Form
    {
        private CalendarBus db = new CalendarBus();
        public User AuthenticatedUser { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var user = db.GetAllUsers().FirstOrDefault(u => u.PhoneNumber ==txtPhoneNumber.Text && u.Password == txtPass.Text);
            if (user != null)
            {
                AuthenticatedUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng", "!Lôĩ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text= string.Empty;
                txtPhoneNumber.Text= string.Empty;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
            this.Show();
            
        }
    }
}
