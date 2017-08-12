using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingCart.BillingSystem
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            grdBilling.Columns.Add("ProductId", "Product ID");
            grdBilling.Columns.Add("ProductName", "Product Name");
            grdBilling.Columns.Add("Quantity", "Quantity");
            grdBilling.Columns.Add("ProductTye", "Product Type");
            grdBilling.Columns.Add("Rate", "Rate");
            grdBilling.Columns.Add("GST", "GST");
            grdBilling.Columns.Add("Discount", "Discount");
            grdBilling.Rows.Add(10);

            
        }
    }
}
