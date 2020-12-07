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
        SalesController salesController = new SalesController();
        ProductsController productsController = new ProductsController();
        ProductTypesController productTypesController = new ProductTypesController();
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void placeBid_Click(object sender, EventArgs e)
        {
            //bid with some kind of concurrency :))
            
            if ((int)bidValue.Value >= int.Parse(cPriceText.Text) / 10 )
            {
                salesController.Bid(saleID, EndOfSemester3.Models.IsLoggedIn.getInstance().userName, (int)bidValue.Value);
            }
            else
            {
                errorText.Visible = true;
            }
           
        }

        public void updateText(int id)
        {
            saleID = id;
            var sale = salesController.Get(id);
            var product = productsController.Get(sale.products_id);
            nameText.Text = product.name;
            pTypeText.Text = productTypesController.Get(product.productTypes_id).type;
            cPriceText.Text = sale.currentPrice + " DKK";
            descriptionText.Text = sale.description;
            timeText.Text = sale.timeRemaining.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeZone.CurrentTimeZone
        }
    }
}
