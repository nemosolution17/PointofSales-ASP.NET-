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
    public class RimReturnController : Controller
    {
        // GET: RimReturn
        public ActionResult RimReturnIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Employee> list = db.Employees.ToList();
            ViewBag.EmpName = new SelectList(list, "emp_id", "emp_name");

            List<Customer> listi = db.Customers.ToList();
            ViewBag.CustName = new SelectList(listi, "cust_id", "cust_name");


            List<Rim_hub> lists = db.Rim_hub.ToList();
            ViewBag.HubName = new SelectList(lists, "hub_id", "hub_name");

            List<Rim_size> liste = db.Rim_size.ToList();
            ViewBag.SizeNo = new SelectList(liste, "size_id", "size_number");

            List<Rim_Type> listp = db.Rim_Type.ToList();
            ViewBag.TypeName = new SelectList(listp, "type_id", "type_name");

            List<Rim_Peg> listj = db.Rim_Peg.ToList();
            ViewBag.PegNo = new SelectList(listj, "peg_id", "peg_no");
            return View();
        }

        public ActionResult RimReturnSave(RimReturn model)
        
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Rim_Return Rim_ret = new Rim_Return();

                Rim_ret.rim_return_date = model.ReturnDate;
                Rim_ret.rim_purchase_date = model.PurchaseDate;
                Rim_ret.emp_id = model.Emp_id;
                Rim_ret.cust_id = model.Cust_id;
                Rim_ret.peg_id = model.Peg_id;
                Rim_ret.hub_id = model.Hub_id;
                Rim_ret.type_id = model.Type_id;
                Rim_ret.size_id = model.Size_id;
                Rim_ret.rim_quant_return = model.RimQuantReturn;

                db.Rim_Return.Add(Rim_ret);
                db.SaveChanges();
                int latestProdId = Rim_ret.rim_return_id;
                TempData["status"] = "Battery Return Successfully Submitted";

                string sql = "update Rims set Rim_quantity = Rim_quantity + @sold_quantity where hub_id= @hub_id and peg_id = @peg_id and type_id = @type_id and size_id = @size_id";
                using (var sqlCon = new SqlConnection(@"Data Source=servername;Initial Catalog=SalesLayan;User ID=sa;Password=password;"))
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    //Have to guess at types and lengths here. Use actual types and lengths from the database
                    cmd.Parameters.Add("@sold_quantity", SqlDbType.SmallInt).Value = model.RimQuantReturn;
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
            return RedirectToAction("RimReturnIndex");
        }

    }

}
