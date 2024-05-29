using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Client
{
    static class Connect
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserManager userManager = new UserManager();
            Login login = new Login(userManager);

            if (login.ShowDialog() == DialogResult.OK)
            {
                Form1 mainForm = new Form1(login.Username);
                Application.Run(mainForm);
            }
        }
    }
}
