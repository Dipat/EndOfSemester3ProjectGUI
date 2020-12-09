using EndOfSemester3.Controllers;
using EndOfSemester3.Models;
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
    public partial class SalesMenu : Form
    {
        public SalesMenu()
        {
            InitializeComponent();
            ProductTypesController productTypesController = new ProductTypesController();
            var types = productTypesController.Get();
            for (int i = 0; i < types.Count(); i++)
            {
                productTypeBox.Items.Add(types.ElementAt(i).Type);
            }
            
        }

        private void createSaleButton_Click(object sender, EventArgs e)
        {
            ProductsController productsController = new ProductsController();
            SalesController salesController = new SalesController();
            int price = int.Parse(startingPriceText.Text);
            int productID = productsController.Create(nameText.Text, price,
                locationText.Text, productTypeBox.SelectedIndex + 1);
            salesController.Create(IsLoggedIn.GetInstance().UserName, productID, DescriptionText.Text, price, (trackBar1.Value+1)*24);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timeLabel.Text = trackBar1.Value + 1 + " Days";
        }
    }
}
