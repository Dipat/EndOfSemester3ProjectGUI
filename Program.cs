using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            new LoginWindow().Show();
            Application.Run();
            //Application.Run(new userMenu());
        }

        public static void backButton_Click(object sender, EventArgs e)
        {
            Form currentWindow = ((Control)sender).FindForm();
            changeWindows(currentWindow, new MainWindow());
        }
        public static void logOut_Click(object sender, EventArgs e)
        {
            Form currentWindow = ((Control)sender).FindForm();
            changeWindows(currentWindow,  new LoginWindow());
        }
        public static void myInfo_Click(object sender, EventArgs e)
        {
            Form currentWindow = ((Control)sender).FindForm();
            changeWindows(currentWindow, new UserMenu());
        }
        public static void createListing_Click(object sender, EventArgs e)
        {
            Form currentWindow = ((Control)sender).FindForm();
            changeWindows(currentWindow, new SalesMenu());
        }

        public static void changeWindows(Form currentWindow, Form window)
        {
            window.Show();   
            currentWindow.Close();
        }
    }
}
