using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class AddyRim
    {
        public System.DateTime Date { get; set; }
        public short Size_id { get; set; }
        public short Type_id { get; set; }
        public short Hub_id { get; set; }
        public short Peg_id { get; set; }
        public string Car_rims { get; set; }
        public short Rim_quantity { get; set; }
        public decimal Rim_unit_price { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
        public string Rim_description { get; set; }
        public short Rim_id { get; set; }
        public short SizeNo { get; set; }
        public string TypeName { get; set; }
        public string HubName { get; set; }
        public short PegNo { get; set; }
    }
}