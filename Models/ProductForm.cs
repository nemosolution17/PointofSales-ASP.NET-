using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Salesapp.Models
{
    public class ProductForm
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Prod_name { get; set; }
        public string Prod_model { get; set; }
        public string Prod_description { get; }
        public string Cat_name { get; set; }
        public short Prod_quantity { get; set; }
        public double Prod_unit_cost_price { get; set; }
        public short Cat_id { get; set; }
        public string ProductName { get; set; }
        public bool Remember { get; set; }


    }
}