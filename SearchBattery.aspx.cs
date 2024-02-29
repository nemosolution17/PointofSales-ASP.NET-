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
    public partial class SearchBattery : System.Web.UI.Page
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
            string sqlquery = "select Date, supplier_name as Maker, size as Size, terminal_name as Terminal, height_name as Height, Batt_quantity as Quantity,  CAST(Batt_Unit_Price   AS VARCHAR(15)) +  ' naira' as Price, Total_price  = Cast((batt_quantity * batt_unit_price) as varchar(15)) + ' naira', Batt_Description as Description from height join Battery on height.height_id = Battery.height_id join Supplier on Supplier.supplier_id = Battery.supplier_id join Terminal on Terminal.terminal_id = Battery.terminal_id join size on size.size_id = battery.size_id where height_name like  '%' + @height_name + '%' or Size like  '%' + @size + '%' or Terminal_name like  '%' + @Terminal_name + '%' or supplier_name like  '%' + @supplier_name + '%' ";
            comn.CommandText = sqlquery;
            comn.Connection = conn;
            comn.Parameters.AddWithValue("supplier_name", TxtSearch.Text);
            comn.Parameters.AddWithValue("Size", TxtSearch.Text);
            comn.Parameters.AddWithValue("Terminal_name", TxtSearch.Text);
            comn.Parameters.AddWithValue("Height_name", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(comn);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}