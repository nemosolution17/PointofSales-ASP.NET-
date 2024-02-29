using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class RimSale
    {

        public System.DateTime Rim_date_sold { get; set; }
        public short Type_id { get; set; }
        public short Hub_id { get; set; }
        public short Peg_id { get; set; }
        public short Size_id { get; set; }
        public short Cust_id { get; set; }
        public short Emp_id { get; set; }
        public short Rim_quantity_purchase { get; set; }
        public decimal Rim_unit_price_sold { get; set; }
        public Nullable<decimal> Rim_total_price_sold { get; set; }
        public int Rim_sales_id { get; set; }
        public short SizeNo { get; set; }
        public string TypeName { get; set; }
        public string HubName { get; set; }
        public short PegNo { get; set; }

    }
}