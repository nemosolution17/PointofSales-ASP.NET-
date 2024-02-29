using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class SalesForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Cust_id { get; set; }
        public short Emp_id { get; set; }
        public string Prod_name { get; set; }
        public string Emp_name { get; set; }
        public short Prod_id { get; set; }
        public short Unit_purchase { get; set; }
        public short Unit_price { get; set; }
        public double Total_price { get; set; }
        public short Sales_id { get; set; }
        //public System.DateTime Dates { get; set; }
        public string SalesName { get; set; }
        public string EmpName { get; set; }
        public string CustName { get; set; }
        public bool Remember { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dates { get; set; }



    }
}