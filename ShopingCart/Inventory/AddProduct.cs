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
        gShopEntities db = new gShopEntities();
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
          if(btnSave.Text=="Submitted")
          {
              btnSave.Text = "Save";
              btnSave.Enabled = true;
          }
            if(txt_pdtId.Text=="")
            {
                MessageBox.Show("Please enter valid Product Code");
                return;
            }

            if (table.Rows.Contains(txt_pdtId.Text))
            {
                MessageBox.Show("Already Exist");
                return;
            }
            
           
            
           

            DataRow dr = table.NewRow();

            
            dr["Pdt_Id"] = txt_pdtId.Text;
            dr["Pdt_Name"] = txt_pdtName.Text;
            dr["Pdt_BuyPrice"] = Convert.ToDecimal(txt_pdtBuy.Text);
            dr["Pdt_SellPrice"] = Convert.ToDecimal(txt_PdtSell.Text);
            dr["Pdt_GST"] = Convert.ToDecimal(txt_PdtGst.Text);
            dr["Pdt_Quantity"] = Convert.ToInt16(txt_PdtQuantity.Text);
            dr["Pdt_Discount"] = Convert.ToInt16(txt_PdtDisc.Text);
            dr["Pdt_PurchaseDate"] = Convert.ToDateTime(txt_PdtPurchase.Text);
            dr["Pdt_Id"] = txt_pdtId.Text;
            if (rdn_Exclusive.Checked)
            {
                dr["Pdt_Tax_Type"] = true;
            }
            else
            {
                dr["Pdt_Tax_Type"] = false;
            }
            
           
            table.Rows.Add(dr);
            grdProductView.DataSource = table;
            txt_pdtId.Text = "";
            txt_pdtName.Text = "";
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == txt_pdtId.Text)
                {
                    table.Rows.Remove(table.Rows[i]);
                    grdProductView.DataSource = table;
                }
            }
            ClearFields();
        }

        public void ClearFields()
        {

            txt_pdtId.Text = "";
            txt_pdtName.Text = "";
            txt_pdtBuy.Text ="0";
            txt_PdtDisc.Text = "0";
            txt_PdtGst.Text = "0";
            txt_PdtPurchase.Text = System.DateTime.Now.Date.ToString();
            txt_PdtQuantity.Text = "0";
            txt_PdtSell.Text = "0";
            
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
            table.Columns.Add("Pdt_Tax_Type");
            table.PrimaryKey = new DataColumn[] { table.Columns["Pdt_Id"] };
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                  
                    var values = (from test in db.Products select test.Pdt_Id).ToList();
                    if (values.Contains(table.Rows[i]["Pdt_Id"].ToString()))
                    {
                        MessageBox.Show("Record" + "'" + table.Rows[i]["Pdt_Id"].ToString() + "'" + "Already exist please remove it and save!!");
                        return;

                    }
                    Product obj = new Product();

                    obj.Pdt_Id = table.Rows[i]["Pdt_Id"].ToString();
                    obj.Pdt_Name = table.Rows[i]["Pdt_Name"].ToString();
                    obj.Pdt_BuyPrice = Convert.ToDecimal(table.Rows[i]["Pdt_BuyPrice"].ToString());
                    obj.Pdt_SellPrice = Convert.ToDecimal(table.Rows[i]["Pdt_SellPrice"].ToString());
                    obj.Pdt_GST = Convert.ToDecimal(table.Rows[i]["Pdt_GST"].ToString());
                    obj.Pdt_Quantity = Convert.ToInt16(table.Rows[i]["Pdt_Quantity"].ToString());
                    obj.Pdt_Discount = Convert.ToInt16(table.Rows[i]["Pdt_Discount"].ToString());
                    obj.Pdt_PurchaseDate = Convert.ToDateTime(table.Rows[i]["Pdt_PurchaseDate"].ToString());
                    obj.Created_DateTime = System.DateTime.Now.Date;
                    if (table.Rows[i]["Pdt_Tax_Type"].ToString() == "True")
                    {
                        obj.Pdt_Tax_Type = true;
                    }
                    else
                    {
                        obj.Pdt_Tax_Type = false;
                    }
                    db.Products.Add(obj);

                }
                db.SaveChanges();
                btnSave.Text = "Submitted";
                btnSave.Enabled = false;
                table.Rows.Clear();
                grdProductView.DataSource = table;
                MessageBox.Show("Record Succussfully created");
            }
           

           

           
        }

        private void grdProductView_SelectionChanged(object sender, EventArgs e)
        {
          
            foreach (DataGridViewRow row in grdProductView.SelectedRows)
            {
                txt_pdtId.Text = row.Cells["Pdt_Id"].Value.ToString();
                txt_pdtName.Text = row.Cells["Pdt_Name"].Value.ToString();
                txt_pdtBuy.Text = row.Cells["Pdt_BuyPrice"].Value.ToString();
                txt_PdtSell.Text = row.Cells["Pdt_SellPrice"].Value.ToString();
                txt_PdtGst.Text = row.Cells["Pdt_GST"].Value.ToString();
                txt_PdtQuantity.Text = row.Cells["Pdt_Quantity"].Value.ToString();
                txt_PdtDisc.Text = row.Cells["Pdt_Discount"].Value.ToString();
                txt_PdtPurchase.Text = row.Cells["Pdt_PurchaseDate"].Value.ToString();
                if (row.Cells["Pdt_Tax_Type"].Value.ToString()=="True")
                {
                    rdn_Exclusive.Checked = true;
                    rdn_Inclusive.Checked = false;
                }
                else
                {
                    rdn_Exclusive.Checked = false;
                    rdn_Inclusive.Checked = true;
                }
                
            
                
                    
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString()==txt_pdtId.Text)
                {
                 
                    table.Rows[i]["Pdt_Name"]=txt_pdtName.Text;
                    table.Rows[i]["Pdt_BuyPrice"]=txt_pdtBuy.Text;
                    table.Rows[i]["Pdt_SellPrice"]=txt_PdtSell.Text;
                    table.Rows[i]["Pdt_GST"]=txt_PdtGst.Text;
                    table.Rows[i]["Pdt_Quantity"]=txt_PdtQuantity.Text;
                    table.Rows[i]["Pdt_Discount"]=txt_PdtDisc.Text;
                    table.Rows[i]["Pdt_PurchaseDate"] = txt_PdtPurchase.Text;
                    if (rdn_Exclusive.Checked)
                    {
                        table.Rows[i]["Pdt_Tax_Type"] = true;
                    }
                    else
                    {
                        table.Rows[i]["Pdt_Tax_Type"] = false;

                    }
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
