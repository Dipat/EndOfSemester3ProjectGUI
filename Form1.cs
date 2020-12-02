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
    public partial class Form1 : Form
    {
        LoginController loginController = new LoginController();
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginController.Login(userNameText.Text, passwordText.Text))
            {
                successMessage.Visible = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int returnCase = loginController.Register(regUserNametext.Text,
                regPasswordText.Text, regNameText.Text,
                regEmailText.Text, regAddressText.Text);
            if(returnCase == 0)
            {
                userNameTakenError.Visible = false;
                registerSuccess.Visible = true;
            }
            else if(returnCase == 1)
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
