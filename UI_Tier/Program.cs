using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            try
            {
              
                using (var db = new CalendarDbContext())
                {
                    db.Database.Initialize(true);
                    
                    MessageBox.Show("✅ Kết nối thành công và đã có dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ KẾT NỐI THẤT BẠI:\n" + ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    
                    Application.Run(new MainForm(loginForm.AuthenticatedUser));
                }
            }
        }
    }
}
