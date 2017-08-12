using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopingCart.BillingSystem;
using ShopingCart.Inventory;
namespace ShopingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void billingToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            Billing bill = new Billing();

            bill.TopLevel = false;
            bill.AutoScroll = true;

            panel1.Controls.Add(bill);
            bill.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 3200;
            panel1.Height = 1200;

            IsMdiContainer = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();

            product.TopLevel = false;
            product.AutoScroll = true;

            panel1.Controls.Add(product);
            product.Show();
        }
    }
}
