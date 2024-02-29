using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salesapp.Models
{
    public class RimReturn
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }


        public short RimQuantReturn { get; set; }
        public short Type_id { get; set; }
        public short Hub_id { get; set; }
        public short Peg_id { get; set; }
        public short Size_id { get; set; }
        public short Emp_id { get; set; }
        public string Emp_name { get; set; }
        public string Cust_name { get; set; }
        public short Rim_size { get; set; }
        public short Cust_id { get; set; }
        public string Rim_type { get; set; }
        public short Rim_id { get; set; }
        public short Batt_return_id { get; set; }
        public string Rimsize { get; set; }
        public string EmpName { get; set; }
        public string CustName { get; set; }
        public short SizeNo { get; set; }
        public string TypeName { get; set; }
        public string HubName { get; set; }
        public short PegNo { get; set; }


    }
}