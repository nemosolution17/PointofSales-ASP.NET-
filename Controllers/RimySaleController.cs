using Salesapp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salesapp.Controllers
{
    public class RimySaleController : Controller
    {
        // GET: RimySale
        public ActionResult RimSaleIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Rim_hub> list = db.Rim_hub.ToList();
            ViewBag.HubName = new SelectList(list, "hub_id", "hub_name");

            List<Rim_size> liste = db.Rim_size.ToList();
            ViewBag.SizeNo = new SelectList(liste, "size_id", "size_number");

            List<Rim_Type> listp = db.Rim_Type.ToList();
            ViewBag.TypeName = new SelectList(listp, "type_id", "type_name");

            List<Rim_Peg> listj = db.Rim_Peg.ToList();
            ViewBag.PegNo = new SelectList(listj, "peg_id", "peg_no");

            List<Customer> listiw = db.Customers.ToList();
            ViewBag.CustName = new SelectList(listiw, "cust_id", "cust_name");

            List<Employee> listi = db.Employees.ToList();
            ViewBag.EmpName = new SelectList(listi, "emp_id", "emp_name");

            return View();
        }

        public ActionResult RimSaleSaves(RimSale model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Rim_Sale_Record RimSales = new Rim_Sale_Record();
                RimSales.hub_id = model.Hub_id;
                RimSales.size_id = model.Size_id;
                RimSales.peg_id = model.Peg_id;
                RimSales.type_id = model.Type_id;
                RimSales.emp_id = model.Emp_id;
                RimSales.cust_id = model.Cust_id;
                RimSales.rim_quantity_purchase = model.Rim_quantity_purchase;
                RimSales.rim_date_sold = model.Rim_date_sold;
                RimSales.rim_unit_price_sold = model.Rim_unit_price_sold;

                db.Rim_Sale_Record.Add(RimSales);
                db.SaveChanges();
                int latestProdId = RimSales.rim_sales_id;
                TempData["status"] = "Success";


                string sql = "update Rims set Rim_quantity = Rim_quantity - @sold_quantity where hub_id= @hub_id and peg_id = @peg_id and type_id = @type_id and size_id = @size_id";
                using (var sqlCon = new SqlConnection(@"Data Source=sourcename;Initial Catalog=SalesLayan;User ID=sa;Password=Password;"))
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    //Have to guess at types and lengths here. Use actual types and lengths from the database
                    cmd.Parameters.Add("@sold_quantity", SqlDbType.SmallInt).Value = model.Rim_quantity_purchase;
                    cmd.Parameters.Add("@hub_id", SqlDbType.SmallInt).Value = model.Hub_id;
                    cmd.Parameters.Add("@peg_id", SqlDbType.SmallInt).Value = model.Peg_id;
                    cmd.Parameters.Add("@type_id", SqlDbType.SmallInt).Value = model.Type_id;
                    cmd.Parameters.Add("@size_id", SqlDbType.SmallInt).Value = model.Size_id;

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }

            }

            catch (Exception ex)
            {
                throw ex;


            }
            return RedirectToAction("RimSaleIndex");
        }
    }
}
