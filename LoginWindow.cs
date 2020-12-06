using EndOfSemester3.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginWindow : Form
    {
        LoginController loginController = new LoginController();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginController.Login(userNameText.Text, passwordText.Text))
            {
                Program.changeWindows(this, new MainWindow());
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            Program.changeWindows(this, new CreateUser());
        }
    }
}
