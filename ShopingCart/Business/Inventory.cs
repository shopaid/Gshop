using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ShopingCart.Entity;
namespace ShopingCart.Business
{
   public class Inventory
    {
       public SqlConnection conn;
       public SqlCommand command;
       public SqlDataAdapter da;

     
       public Inventory()
       {
           conn = new SqlConnection("");
           conn.Open();

       }

       public String AddStock(InventoryEntity inventoryDetails)
       {


           return "";
       }

    }
}
