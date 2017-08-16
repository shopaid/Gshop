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
        DataTable table = new DataTable();
        gShopEntities db = new gShopEntities();

        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Items");
            table.Columns.Add("Name");
            table.Columns.Add("Rate");
            table.Columns.Add("Tax GST");
            table.Columns.Add("Quatity");
            table.Columns.Add("Discount");
            table.Columns.Add("Tax Type");
            table.PrimaryKey = new DataColumn[] { table.Columns["Items"] };
            grdBilling.DataSource = table;
        }

        private void grdBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
               
                Bill bill = new Bill();
                bill.customer_Name = txt_CusName.ToString();
                bill.customer_Address = rch_cusAddress.ToString();
                bill.customer_Mobile = txt_cusMobile.ToString();
                bill.bill_Date = Convert.ToDateTime(dt_billDate);
                bill.pdt_Count = Convert.ToInt16(txt_pdtCount);
                bill.pdt_QuantityCount = Convert.ToInt16(txt_QuantCount);
                db.Bills.Add(bill);
                db.SaveChanges();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Bill_Details billDetails = new Bill_Details();

                    billDetails.bill_Id = bill.bill_Id;
                    billDetails.pdt_Id = table.Rows[i]["Items"].ToString();
                    billDetails.pdt_Name = table.Rows[i]["Name"].ToString();
                    billDetails.pdt_Rate = Convert.ToDecimal(table.Rows[i]["Rate"]);
                    billDetails.pdt_GST = Convert.ToDecimal(table.Rows[i]["Tax GST"]);
                    billDetails.pdt_Qauntity = Convert.ToInt16(table.Rows[i]["Quatity"]);
                    billDetails.pdt_Discount = Convert.ToInt16(table.Rows[i]["Discount"]);
                    db.Bill_Details.Add(billDetails);
                    db.SaveChanges();
                }

                MessageBox.Show("Record Succussfully created");

            }
            else
            {
                MessageBox.Show("Please Add items");
            }
        }

        private void grdBilling_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            MessageBox.Show("index"+ index);

            string newVal = this.grdBilling.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if(!string.IsNullOrEmpty(newVal))
            {
                var values = (from pdt in db.Products
                              where pdt.Pdt_Id == newVal
                              select pdt);

                if (values != null)
                {
                    foreach(var pdtitems in values)
                    {
                        table.Rows[index]["Items"] = pdtitems.Pdt_Id;
                        table.Rows[index]["Name"] = pdtitems.Pdt_Name;
                        table.Rows[index]["Rate"] = pdtitems.Pdt_SellPrice;
                        table.Rows[index]["Tax GST"] = pdtitems.Pdt_GST;
                        table.Rows[index]["Tax Type"] = pdtitems.Pdt_Id;
                    }
                }
            }
            MessageBox.Show(newVal);
        }
     }
}
