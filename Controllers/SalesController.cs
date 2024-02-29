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
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SalesIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Product> list = db.Products.ToList();
            ViewBag.SalesName = new SelectList(list, "prod_id", "prod_name");

            List<Employee> listi = db.Employees.ToList();
            ViewBag.EmpName = new SelectList(listi, "emp_id", "emp_name");


            List<Customer> listiw = db.Customers.ToList();
            ViewBag.CustName = new SelectList(listiw, "cust_id", "cust_name");



            return View();
        }

        public ActionResult SaveSales(SalesForm model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Sales_Record sale_prod = new Sales_Record();

                sale_prod.unit_price = model.Unit_price;
                sale_prod.unit_purchase = model.Unit_purchase; 
                sale_prod.prod_id = model.Prod_id;
                sale_prod.emp_id = model.Emp_id;
                sale_prod.Dates = model.Dates;
                sale_prod.cust_id = model.Cust_id;

                db.Sales_Record.Add(sale_prod);
                db.SaveChanges();
                int latestProdId = sale_prod.sales_id;
                TempData["status"] = "Success";


               
                string sql = "update product set prod_quantity=prod_quantity- @sold_quantity where prod_id= @Prod_ID";
                using (var sqlCon = new SqlConnection(@"Data Source=LAPTOP-L99NV78V\LAYANSQL;Initial Catalog=SalesLayan;User ID=sa;Password=Layangrade@17;"))
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    //Have to guess at types and lengths here. Use actual types and lengths from the database
                    cmd.Parameters.Add("@sold_quantity", SqlDbType.SmallInt).Value = model.Unit_purchase;
                    cmd.Parameters.Add("@Prod_ID", SqlDbType.SmallInt).Value = model.Prod_id;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }

             

            }

            catch (Exception ex)
            {
                throw ex;


            }
            return RedirectToAction("SalesIndex");
        }
    }  
}