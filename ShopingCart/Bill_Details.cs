//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopingCart
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Details
    {
        public int bill_DetailsId { get; set; }
        public int bill_Id { get; set; }
        public string pdt_Id { get; set; }
        public string pdt_Name { get; set; }
        public Nullable<decimal> pdt_Rate { get; set; }
        public Nullable<decimal> pdt_GST { get; set; }
        public Nullable<int> pdt_Qauntity { get; set; }
        public Nullable<decimal> pdt_Discount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
