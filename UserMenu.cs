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
        SalesController salesController = new SalesController();
        ProductsController productsController = new ProductsController();
        int numberOfSalesDone = 0;
        public UserMenu()
        {
            InitializeComponent();
            updateFields(IsLoggedIn.GetInstance().UserName);
            this.backButton.Click += new EventHandler(Program.backButton_Click);
            UpdateSales();
            nSalesText.Text = numberOfSalesDone.ToString();
        }

        public void UpdateOwnSaleGrid(string productName, int price, Color color, int saleID)
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
            itemNameText.ForeColor = color;
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
            priceText.ForeColor = color;
            priceText.Click += new EventHandler(product_Click);

            //ID Invisible Textbox declaration
            Label saleIdText = new Label();
            saleIdText.AutoSize = true;
            saleIdText.Location = new Point(747, 0);
            saleIdText.Name = "saleIdText";
            saleIdText.Size = new Size(13, 26);
            saleIdText.TabIndex = 3;
            saleIdText.Text = saleID.ToString();
            saleIdText.Visible = false;

            ownSalesGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //ownSalesGrid.Controls.Add(pictureBox, 0, ownSalesGrid.RowCount-1);
            ownSalesGrid.Controls.Add(itemNameText, 0, ownSalesGrid.RowCount - 1);
            ownSalesGrid.Controls.Add(priceText, 1, ownSalesGrid.RowCount - 1);
            ownSalesGrid.Controls.Add(saleIdText, 2, ownSalesGrid.RowCount - 1);
        }

        public void UpdateOwnBidsGrid(string productName, int price, int saleID)
        {
            ownBidsGrid.RowCount = ownBidsGrid.RowCount + 1;

            //Product Name Textbox declaration
            Label bidNameText = new Label();
            bidNameText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            bidNameText.Location = new Point(3, 0);
            bidNameText.Name = "bidNameText";
            bidNameText.Size = new Size(104, 62);
            bidNameText.TabIndex = 2;
            bidNameText.Text = productName;
            bidNameText.TextAlign = ContentAlignment.MiddleLeft;
            bidNameText.Click += new EventHandler(product_Click);

            //Price Textbox declaration
            Label bidPriceText = new Label();
            bidPriceText.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            bidPriceText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            bidPriceText.Location = new Point(122, 0);
            bidPriceText.Name = "bidPriceText";
            bidPriceText.Size = new Size(98, 62);
            bidPriceText.TabIndex = 3;
            bidPriceText.Text = price + " DKK";
            bidPriceText.TextAlign = ContentAlignment.MiddleRight;
            bidPriceText.Click += new EventHandler(product_Click);

            //ID Invisible Textbox declaration
            Label bidIdText = new Label();
            bidIdText.AutoSize = true;
            bidIdText.Location = new Point(747, 0);
            bidIdText.Name = "bidIdText";
            bidIdText.Size = new Size(13, 26);
            bidIdText.TabIndex = 3;
            bidIdText.Text = saleID.ToString();
            bidIdText.Visible = false;

            ownBidsGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            ownBidsGrid.Controls.Add(bidNameText, 0, ownBidsGrid.RowCount - 1);
            ownBidsGrid.Controls.Add(bidPriceText, 1, ownBidsGrid.RowCount - 1);
            ownBidsGrid.Controls.Add(bidIdText, 2, ownBidsGrid.RowCount - 1);

        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductWindow window = new ProductWindow();
            int row = ownBidsGrid.GetRow((Control)sender);
            int id = int.Parse(GetAnyControlAt(ownBidsGrid, 2, row).Text);
            window.UpdateText(id);
            window.Show();
            Close();
        }

        public Control GetAnyControlAt(TableLayoutPanel panel, int column, int row)
        {
            foreach (Control control in panel.Controls)
            {
                var cellPosition = panel.GetCellPosition(control);
                if (cellPosition.Column == column && cellPosition.Row == row)
                    return control;
            }
            return null;
        }

        private void saveUpdates_Click(object sender, EventArgs e)
        {
            errorText.Visible = false;
            if (passwordText.Text == cPasswordText.Text)
            {
                if (!usersController.Update(usernameText.Text, passwordText.Text, nameText.Text, emailText.Text, addressText.Text))
                {
                    errorText.Visible = true;
                }
            }
            else
            {
                errorText.Visible = true;
            }
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

        public void UpdateSales()
        {
            var sales = salesController.Get();
            ownSalesGrid.Controls.Clear();
            ownBidsGrid.Controls.Clear();
            numberOfSalesDone = 0;
            for (int i = 0; i < sales.Count(); i++)
            {
                var sale = sales.ElementAt(i);
                if (sale.Users_id == IsLoggedIn.GetInstance().UserName && sale.HighestBidder_id != null)
                {
                    if (!sale.IsActive)
                    {
                        UpdateOwnSaleGrid(productsController.Get(sale.Products_id).Name, sale.CurrentPrice, Color.Red, sale.Id);
                        numberOfSalesDone++;
                    }
                    else
                    {
                        UpdateOwnSaleGrid(productsController.Get(sale.Products_id).Name, sale.CurrentPrice, Color.Green, sale.Id);
                    }
                }
                if (sale.HighestBidder_id == IsLoggedIn.GetInstance().UserName)
                {
                    UpdateOwnBidsGrid(productsController.Get(sale.Products_id).Name, sale.CurrentPrice, sale.Id);
                }
            }
            usersController.UpdateNumberOfSales(IsLoggedIn.GetInstance().UserName, numberOfSalesDone);
        }
    }
}
