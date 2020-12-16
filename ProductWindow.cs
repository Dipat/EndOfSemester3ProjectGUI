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
    public partial class ProductWindow : Form
    {
        private int saleID = 0;
        private bool errorTextVisible = false;
        SalesController salesController = new SalesController();
        ProductsController productsController = new ProductsController();
        ProductTypesController productTypesController = new ProductTypesController();
        public ProductWindow()
        {
            InitializeComponent();
            this.createListing.Click += new EventHandler(Program.createListing_Click);
            this.logOut.Click += new EventHandler(Program.logOut_Click);
            this.myInfo.Click += new EventHandler(Program.myInfo_Click);
            this.backButton.Click += new EventHandler(Program.backButton_Click);
        }

        private void placeBid_Click(object sender, EventArgs e)
        {
            //bid with some kind of concurrency :))
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
            UpdatePrice();
        }

        public void UpdateText(int id)
        {
            saleID = id;
            var sale = salesController.Get(id);
            var product = productsController.Get(sale.Products_id);
            nameText.Text = product.Name;
            pTypeText.Text = productTypesController.Get(product.ProductTypes_id).Type;
            descriptionText.Text = sale.Description;
            timeText.Text = sale.EndTime.ToString();
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            var sale = salesController.Get(saleID);
            cPriceText.Text = sale.CurrentPrice.ToString();
            bidValue.Minimum = sale.CurrentPrice / 10;
            if (bidValue.Minimum < 1)
            {
                bidValue.Minimum = 1;
            }
            if (errorTextVisible)
            {
                errorText.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!salesController.Bid(saleID, EndOfSemester3.Models.IsLoggedIn.GetInstance().UserName, (int)bidValue.Value))
            {
                errorTextVisible = true;
            }
        }
    }
}
