using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingCart.Inventory
{
    public partial class AddProduct : Form
    {
        DataTable table = new DataTable();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            gShopEntities db = new gShopEntities();
           
            
           

            DataRow dr = table.NewRow();

            
            dr["Pdt_Id"] = txt_pdtId.Text;
            table.Rows.Add(dr);
            grdProductView.DataSource = table;
            
         
            //var values = from test in db.Products select test;
            
            //        Product obj = new Product();            
            //        obj.Pdt_Id = txt_pdtId.Text;
            //        obj.Pdt_Name = txt_pdtName.Text;
            //        obj.Pdt_BuyPrice = Convert.ToDecimal(txt_pdtBuy.Text);
            //        obj.Pdt_SellPrice = Convert.ToDecimal(txt_PdtSell.Text);
            //        obj.Pdt_GST = Convert.ToDecimal(txt_PdtGst.Text);
            //        obj.Pdt_Quantity = Convert.ToInt16(txt_PdtQuantity.Text);
            //        obj.Pdt_Discount = Convert.ToInt16(txt_PdtDisc.Text);
            //        obj.Pdt_PurchaseDate = Convert.ToDateTime(txt_PdtPurchase.Text);
            //        if (rdn_Exclusive.Checked)
            //        {
            //            obj.Pdt_Tax_Type = true;
            //        }
            //        db.Products.Add(obj);
            //        db.SaveChanges();
                         
            //grdProductView.DataSource=

            MessageBox.Show("Record Succussfully created");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Pdt_Id");
            table.Columns.Add("Pdt_Name");
            table.Columns.Add("Pdt_BuyPrice");
            table.Columns.Add("Pdt_SellPrice");
            table.Columns.Add("Pdt_GST");
            table.Columns.Add("Pdt_Quantity");
            table.Columns.Add("Pdt_Discount");
            table.Columns.Add("Pdt_PurchaseDate");
        }
    }
}
