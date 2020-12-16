using EndOfSemester3.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CreateUser : Form
    {
        LoginController loginController = new LoginController();
        public CreateUser()
        {
            InitializeComponent();
            this.backButton.Click += new EventHandler(Program.logOut_Click);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int returnCase = loginController.Register(regUserNametext.Text,
                regPasswordText.Text, regNameText.Text,
                regEmailText.Text, regAddressText.Text);
            if (returnCase == 0)
            {
                Program.changeWindows(this, new MainWindow());
            }
            else if (returnCase == 1)
            {
                userNameTakenError.Visible = true;
            }
            else
            {
                //Registration failed
            }
        }
    }
}
