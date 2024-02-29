using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Salesapp
{
    public partial class OurProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
        
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["SalesLayanConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(sqlcon);
            conn.Open();
            SqlCommand comn = new SqlCommand();
            string sqlquery = "select prod_name Products, prod_model as Model, prod_description as Descriptions, prod_quantity as Quantity, prod_unit_cost_price as Price, cat_name as Category from product join Product_Category on product.cat_id = Product_Category.cat_id where prod_model like '%' +@prod_model+'%'";
            comn.CommandText = sqlquery;
            comn.Connection = conn;
            comn.Parameters.AddWithValue("prod_model", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(comn);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
    }
}