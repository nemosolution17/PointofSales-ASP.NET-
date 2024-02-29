using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class BattSales
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Batt_date_sold { get; set; }

        public short Emp_id { get; set; }
        public short Supplier_id { get; set; }
        public string Supplier_name { get; set; }
        public short Batt_id { get; set; }
        public short Cust_id { get; set; }
        public int Batt_quantity_purchased { get; set; }
        public decimal Batt_unit_price_purchased { get; set; }
        public Nullable<decimal> Batt_total_price_purchased { get; set; }
        public int Batt_sale_id { get; set; }
        public string Cust_name { get; set; }
        public string Emp_name { get; set; }
        public string Batt_maker { get; set; }
        public string BattterminalNamne { get; set; }
        public string HeightName { set; get; }
        public string CustName { set; get; }
        public string EmpName { set; get; }
        public short Terminal_id { get; set; }
        public string Terminal_name { get; set; }
        public short Height_id { get; set; }
        public string Height_name { get; set; }
        public string SupplierName { set; get; }
        public short Size_id { get; set; }
        public string Size1 { get; set; }
        public string SizeName { get; set; }
    }




}