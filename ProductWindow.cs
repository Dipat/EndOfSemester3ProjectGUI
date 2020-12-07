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
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void placeBid_Click(object sender, EventArgs e)
        {
            //bid with some kind of concurrency :))
            SalesController salesController = new SalesController();
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
            if(id == 1)
            {
                nameText.Text = "asd";
            }
            
        }
    }
}
