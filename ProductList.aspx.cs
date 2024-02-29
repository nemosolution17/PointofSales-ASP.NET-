using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Salesapp
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-L99NV78V\LAYANSQL;Initial Catalog=SalesLayan;User ID=sa;Password=Layangrade@17;"))
            {
                sqlCon.Open();
                SqlDataAdapter sqldaDa = new SqlDataAdapter("select * from product", sqlCon);
                DataTable dtb1 = new DataTable();
                sqldaDa.Fill(dtb1);
                prodlist.DataSource = dtb1;
                prodlist.DataBind();


            }

        }
    }
}