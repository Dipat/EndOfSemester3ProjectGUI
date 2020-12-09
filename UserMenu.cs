using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EndOfSemester3.Controllers;
using EndOfSemester3.Models;

namespace WindowsFormsApp2
{
    public partial class UserMenu : Form
    {
        UsersController usersController = new UsersController();
        EncryptionController encryptionController = new EncryptionController();
        public UserMenu()
        {
            InitializeComponent();
            updateFields(IsLoggedIn.GetInstance().UserName);
        }

        public void UpdateGrid(string productName, int price)
        {
            ownSalesGrid.RowCount = ownSalesGrid.RowCount + 1;
            //Picture box declaration
            /*PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources._79c;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(150, 139);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;*/

            //Product Name Textbox declaration
            Label itemNameText = new Label();
            itemNameText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            itemNameText.Location = new Point(3, 0);
            itemNameText.Name = "itemNameText";
            itemNameText.Size = new Size(104, 62);
            itemNameText.TabIndex = 2;
            itemNameText.Text = productName;
            itemNameText.TextAlign = ContentAlignment.MiddleLeft;
            itemNameText.Click += new EventHandler(product_Click);

            //Price Textbox declaration
            Label priceText = new Label();
            priceText.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            priceText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            priceText.Location = new Point(122, 0);
            priceText.Name = "priceText";
            priceText.Size = new Size(98, 62);
            priceText.TabIndex = 3;
            priceText.Text = price + " DKK";
            priceText.TextAlign = ContentAlignment.MiddleRight;
            priceText.Click += new EventHandler(product_Click);

            ownSalesGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //ownSalesGrid.Controls.Add(pictureBox, 0, ownSalesGrid.RowCount-1);
            ownSalesGrid.Controls.Add(itemNameText, 0, ownSalesGrid.RowCount - 1);
            ownSalesGrid.Controls.Add(priceText, 1, ownSalesGrid.RowCount - 1);

        }

        private void product_Click(object sender, EventArgs e)
        {
            UpdateGrid("product", 15);
        }

        private void saveUpdates_Click(object sender, EventArgs e)
        {
            usersController.Update(usernameText.Text, passwordText.Text, nameText.Text, emailText.Text, addressText.Text);
        }

        public void updateFields(string username)
        {
            var user = usersController.Get(username);
            usernameText.Text = username;
            string decryptedValue = encryptionController.DecryptPassword(user.Password);
            passwordText.Text = decryptedValue.Substring(0, decryptedValue.Length - user.Salt.Length);
            nameText.Text = user.Name;
            emailText.Text = user.Email;
            addressText.Text = user.Address;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
