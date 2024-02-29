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
    public class BattSaleController : Controller
    {
        // GET: BattSale
        public ActionResult BattSaleIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14 ();
            List<Size> list = db.Sizes.ToList();
            ViewBag.SizeName = new SelectList(list, "size_id", "size1");

            List<Employee> listi = db.Employees.ToList();
            ViewBag.EmpName = new SelectList(listi, "emp_id", "emp_name");

            List<Terminal> listt = db.Terminals.ToList();
            ViewBag.BattterminalNamne = new SelectList(listt, "terminal_id", "terminal_name");

            List<Height> listy = db.Heights.ToList();
            ViewBag.HeightName = new SelectList(listy, "height_id", "height_name");


            List<Customer> listiw = db.Customers.ToList();
            ViewBag.CustName = new SelectList(listiw, "cust_id", "cust_name");

            List<Supplier> listp = db.Suppliers.ToList();
            ViewBag.SupplierName = new SelectList(listp, "supplier_id", "Supplier_name");

            return View();
        }

        public ActionResult BattSaleSave(BattSales model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                batt_sales_record battSales = new batt_sales_record();
                battSales.supplier_id = model.Supplier_id;
                battSales.size_id = model.Size_id;
                battSales.terminal_id = model.Terminal_id;
                battSales.height_id = model.Height_id;
                battSales.emp_id = model.Emp_id;
                battSales.cust_id = model.Cust_id;
                battSales.batt_quantity_purchased = model.Batt_quantity_purchased;
                battSales.batt_unit_price_purchased = model.Batt_unit_price_purchased;
                battSales.batt_date_sold = model.Batt_date_sold;

                db.batt_sales_record.Add(battSales);
                db.SaveChanges();
                int latestProdId = battSales.batt_sale_id;
                TempData["status"] = "Success";

                
                string sql = "update battery set batt_quantity = batt_quantity - @sold_quantity where supplier_id= @supplier_id and size_id = @size and terminal_id = @terminal_id and height_id = @height_id";
                using (var sqlCon = new SqlConnection(@"Data Source=servername;Initial Catalog=SalesLayan;User ID=sa;Password=password;"))
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    //Have to guess at types and lengths here. Use actual types and lengths from the database
                    cmd.Parameters.Add("@sold_quantity", SqlDbType.SmallInt).Value = model.Batt_quantity_purchased;
                    cmd.Parameters.Add("@supplier_id", SqlDbType.SmallInt).Value = model.Supplier_id;
                    cmd.Parameters.Add("@terminal_id", SqlDbType.SmallInt).Value = model.Terminal_id;
                    cmd.Parameters.Add("@height_id", SqlDbType.SmallInt).Value = model.Height_id;
                    cmd.Parameters.Add("@size", SqlDbType.SmallInt).Value = model.Size_id;

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
                
            }

            catch (Exception ex)
            {
                throw ex;


            }
            return RedirectToAction("BattSaleIndex");
        }

             
        
    }
}
