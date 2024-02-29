using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Salesapp
{
    public partial class AddBattery : System.Web.UI.Page
    {
        public short Supplier_id { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-L99NV78V\LAYANSQL;Initial Catalog=SalesLayan;User ID=sa;Password=Layangrade@17;"))
            {
                sqlCon.Open();
                string query = "insert into battery " + "(Maker,size,terminal,height,batt_quantity,batt_unit_price, batt_description) values(@Maker,@size,@terminal,@height,@batt_quantity,@batt_unit_price, @batt_description)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@maker", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@size", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@terminal", DropDownList1.SelectedItem.Value);
                sqlCmd.Parameters.AddWithValue("@height", DropDownList2.SelectedItem.Value);
                sqlCmd.Parameters.AddWithValue("@batt_quantity", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@batt_unit_price", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@batt_description", TextBox4.Text);
                sqlCmd.ExecuteNonQuery();
                Label1.Text = "New Rim Successfully Submitted";
                Label2.Text = "New Rim Successfully Submitted";
            }
        }
    }
}