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
    public partial class MainWindow : Form
    {
        SalesController salesController = new SalesController();
        ProductsController productsController = new ProductsController();
        ProductTypesController productTypesController = new ProductTypesController();
        bool sortingActive = false;
        public MainWindow()
        {
            InitializeComponent();
            var types = productTypesController.Get();
            for (int i = 0; i < types.Count(); i++)
            {
                productTypeBox.Items.Add(types.ElementAt(i).Type);
            }
            this.createListing.Click += new EventHandler(Program.createListing_Click);
            this.logOut.Click += new EventHandler(Program.logOut_Click);
            this.myInfo.Click += new EventHandler(Program.myInfo_Click);
            ActiveChecker();
            UpdateSales();
        }

        public void UpdateGrid(string productName, int price, int saleID)
        {
            salesGrid.RowCount = salesGrid.RowCount + 1;
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
            itemNameText.Size = new Size(673, 62);
            itemNameText.TabIndex = 1;
            itemNameText.Text = productName;
            itemNameText.TextAlign = ContentAlignment.MiddleLeft;
            itemNameText.Click += new EventHandler(product_Click);

            //Price Textbox declaration
            Label priceText = new Label();
            priceText.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            priceText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            priceText.Location = new Point(682, 0);
            priceText.Name = "priceText";
            priceText.Size = new Size(104, 62);
            priceText.TabIndex = 2;
            priceText.Text = price + " DKK";
            priceText.TextAlign = ContentAlignment.MiddleRight;
            priceText.Click += new EventHandler(product_Click);

            //ID Invisible Textbox declaration
            Label idText = new Label();
            idText.AutoSize = true;
            idText.Location = new Point(747, 0);
            idText.Name = "idText";
            idText.Size = new Size(13, 26);
            idText.TabIndex = 3;
            idText.Text = saleID.ToString();
            idText.Visible = false;

            salesGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //salesGrid.Controls.Add(pictureBox, 0, salesGrid.RowCount-1);
            salesGrid.Controls.Add(itemNameText, 0, salesGrid.RowCount-1);
            salesGrid.Controls.Add(priceText, 1, salesGrid.RowCount-1);
            salesGrid.Controls.Add(idText, 2, salesGrid.RowCount - 1);
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductWindow window = new ProductWindow();
            int row = salesGrid.GetRow((Control)sender);
            int id = int.Parse(GetAnyControlAt(salesGrid, 2, row).Text);
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

        public void UpdateSales()
        {
            var sales = salesController.GetActive();
            salesGrid.Controls.Clear();
            for (int i = 0; i < sales.Count(); i++)
            {
                var sale = sales.ElementAt(i);
                UpdateGrid(productsController.Get(sale.Products_id).Name, sale.CurrentPrice, sale.Id);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!sortingActive)
            {
                UpdateSales();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            Sort("name");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort("price");
        }

        private void productTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort("type");
        }

        private void Sort(string sortBy)
        {
            var sales = salesController.GetActive();
            switch (sortBy)
            {
                case "name":
                    sales = salesController.FindSaleByProductName(textBox1.Text);
                    break;
                case "price":
                    sales = salesController.SortSales(comboBox1.Text);
                    break;
                case "type":
                    sales = salesController.SortSales(productTypeBox.Text);
                    break;
                default:
                    break;
            }
            sortingActive = true;
            salesGrid.Controls.Clear();
            for (int i = 0; i < sales.Count(); i++)
            {
                var sale = sales.ElementAt(i);
                UpdateGrid(productsController.Get(sale.Products_id).Name, sale.CurrentPrice, sale.Id);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ActiveChecker();
        }

        private void ActiveChecker()
        {
            var sales = salesController.GetActive();
            for (int i = 0; i < sales.Count(); i++)
            {
                if (sales.ElementAt(i).EndTime.CompareTo(DateTime.Now) <= 0)
                {
                    salesController.SetInactive(sales.ElementAt(i).Id);
                }
            }
        }
    }
}
