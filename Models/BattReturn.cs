using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class BattReturn
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }

        public short Supplier_id { get; set; }
        public short Height_id { get; set; }
        public short Size_id { get; set; }
        public short Terminal_id { get; set; }
        public short Emp_id { get; set; }
        public string Emp_name { get; set; }
        public string Cust_name { get; set; }
        public short QuantityReturn { get; set; }
     
        public short Cust_id { get; set; }
        public string Battery_maker { get; set; }
        public short Batt_id { get; set; }
        public short Batt_return_id { get; set; }
        public string Battsize { get; set; }
        public string EmpName { get; set; }
        public string CustName { get; set; }
        public string SupplierName { get; set; }
        public string HeightName { get; set; }
        public string SizeName { get; set; }
        public string TerminalName { get; set; }
    }
}