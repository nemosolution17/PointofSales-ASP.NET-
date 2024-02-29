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
    public partial class SearchRims : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["SalesLayanConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(sqlcon);
            conn.Open();
            SqlCommand comn = new SqlCommand();
            string sqlquery = "select Date, type_name as Type, hub_name as Hub, size_number as Size, peg_no as Peg, rim_quantity as Quantity, CAST(rim_unit_price   AS VARCHAR(15)) +  ' naira' Price, rim_description as Description, Total_Amount  = Cast((Rim_quantity * Rim_unit_price) as varchar(15)) + ' naira' from Rim_size join Rims on rim_size.size_id = rims.size_id join Rim_Type on rim_type.type_id =rims.type_id join Rim_hub on Rim_hub.hub_id = rims.hub_id join Rim_Peg on Rim_Peg.peg_id = rims.peg_id where type_name like  '%' + @type_name + '%' or hub_name like  '%' + @hub_name + '%'or peg_no like  '%' + @peg_no + '%' or size_number like  '%' + @size_number + '%' or rim_description like  '%' + @rim_description + '%'";
            comn.CommandText = sqlquery;
            comn.Connection = conn;
            comn.Parameters.AddWithValue("peg_no",TxtSearch.Text);
            comn.Parameters.AddWithValue("type_name", TxtSearch.Text);
            comn.Parameters.AddWithValue("size_number", TxtSearch.Text);
            comn.Parameters.AddWithValue("hub_name", TxtSearch.Text);
            comn.Parameters.AddWithValue("rim_description", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(comn);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}