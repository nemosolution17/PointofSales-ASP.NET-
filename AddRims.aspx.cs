using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salesapp
{
    public partial class AddRims : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-L99NV78V\LAYANSQL;Initial Catalog=SalesLayan;User ID=sa;Password=Layangrade@17;"))
            {
                sqlCon.Open();
                string query = "insert into rims " + "(rim_size,rim_type, car_rims,rim_quantity, rim_unit_price, rim_description) values(@rim_size,@rim_type, @car_rims,@rim_quantity, @rim_unit_price, @rim_description)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@rim_type", DropDownList1.SelectedItem.Value);
                sqlCmd.Parameters.AddWithValue("@rim_size", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@car_rims", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@rim_quantity", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@rim_unit_price", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@rim_description", TextBox5.Text);
                sqlCmd.ExecuteNonQuery();
                Label1.Text = "New Rim Successfully Submitted";
                Label2.Text = "New Rim Successfully Submitted";


            }

        }
    }
}