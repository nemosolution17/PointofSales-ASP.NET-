using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Salesapp
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-L99NV78V\LAYANSQL;Initial Catalog=SalesLayan;User ID=sa;Password=Layangrade@17;"))
            {
                sqlCon.Open();
                string query = "insert into customers " + "(cust_name,cust_phone_no, cust_email,cust_city,cust_state) values(@cust_name,@cust_phone_no, @cust_email,@cust_city, @cust_state)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@cust_name", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@cust_phone_no", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@cust_email", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@cust_city", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@cust_state", TextBox3.Text);
                sqlCmd.ExecuteNonQuery();
            }

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}