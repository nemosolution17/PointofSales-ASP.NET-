using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class AddyBattery
    {
        public System.DateTime Date { get; set; }

        
        public short Terminal_id { get; set; }
        public short Height_id { get; set; }
        public short Batt_quantity { get; set; }
        public decimal Batt_Unit_Price { get; set; }
        public Nullable<decimal> Total_Price { get; set; }
        public string Batt_description { get; set; }
        public short Batt_id { get; set; }
        public string SupplierName { get; set; }
        public short Supplier_id { get; set; }
        public string Supplier_name { get; set; }
        public string TerminalName { get; set; }
        public string HeightName { get; set; }
        public short Size_id { get; set; }
        public string Size1 { get; set; }
        public string SizeName { get; set; }
    }
}