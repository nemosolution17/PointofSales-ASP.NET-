//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salesapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Return_product
    {
        public short return_id { get; set; }
        public short cust_id { get; set; }
        public Nullable<System.DateTime> Purchase_Date { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
        public short prod_id { get; set; }
        public short emp_id { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
