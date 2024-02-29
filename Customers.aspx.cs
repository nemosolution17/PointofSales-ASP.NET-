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
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlcon = ConfigurationManager.ConnectionStrings["SalesLayanConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(sqlcon);
            conn.Open();
            SqlCommand comn = new SqlCommand();
            string sqlquery = "select cust_name as Name, cust_phone_no as Phone_Number, cust_email as Email, cust_city as City, cust_state as State from Customers where cust_name like  '%' + @cust_name + '%' or cust_phone_no like  '%' + @cust_phone_no + '%' or cust_email like  '%' + @cust_email + '%' or cust_city like  '%' + @cust_city + '%' or cust_state like  '%' + @cust_state + '%' ";
            comn.CommandText = sqlquery;
            comn.Connection = conn;
            comn.Parameters.AddWithValue("cust_name", TextBox1.Text);
            comn.Parameters.AddWithValue("cust_phone_no", TextBox1.Text);
            comn.Parameters.AddWithValue("cust_email", TextBox1.Text);
            comn.Parameters.AddWithValue("cust_city", TextBox1.Text);
            comn.Parameters.AddWithValue("cust_state", TextBox1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(comn);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}