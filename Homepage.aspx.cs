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
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }



        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("SearchRims.aspx");
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RimySale/RimSaleIndex");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("BattSale/BattSaleIndex");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddyRims/AddyRimIndex");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddBattery/BattAddIndex");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("SearchBattery.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("RimList.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("BatteryList.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCustomer.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("RimReturn/RimReturnIndex");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("BattReturn/BattReturnIndex");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("RimSaleList.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("BattSaleList.aspx");
        }
    }
}