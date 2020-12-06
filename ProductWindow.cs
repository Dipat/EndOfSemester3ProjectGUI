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
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void placeBid_Click(object sender, EventArgs e)
        {
            //bid with some kind of concurrency :))
        }

        public void updateText(int id)
        {
            if(id == 1)
            {
                nameText.Text = "asd";
            }
            
        }
    }
}
