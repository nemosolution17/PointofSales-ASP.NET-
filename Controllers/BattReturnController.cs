using Salesapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salesapp.Controllers
{
    public class BattReturnController : Controller
    {
        // GET: BattReturn
        public ActionResult BattReturnIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Employee> list = db.Employees.ToList();
            ViewBag.EmpName = new SelectList(list, "emp_id", "emp_name");

            List<Customer> listi = db.Customers.ToList();
            ViewBag.CustName = new SelectList(listi, "cust_id", "cust_name");


            List<Size> listl = db.Sizes.ToList();
            ViewBag.SizeName = new SelectList(listl, "size_id", "size1");

            List<Supplier> listp = db.Suppliers.ToList();
            ViewBag.SupplierName = new SelectList(listp, "supplier_id", "Supplier_name");

            List<Terminal> listt = db.Terminals.ToList();
            ViewBag.TerminalName = new SelectList(listt, "terminal_id", "terminal_name");

            List<Height> listy = db.Heights.ToList();
            ViewBag.HeightName = new SelectList(listy, "height_id", "height_name");
            return View();

        }

        public ActionResult BattReturnSave(BattReturn model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Batt_Return batt_ret = new Batt_Return();

                batt_ret.return_date = model.ReturnDate;
                batt_ret.purchase_date = model.PurchaseDate;
                batt_ret.emp_id = model.Emp_id;
                batt_ret.cust_id = model.Cust_id;
                batt_ret.size_id = model.Size_id;
                batt_ret.height_id = model.Height_id;
                batt_ret.terminal_id = model.Terminal_id;
                batt_ret.supplier_id = model.Supplier_id;
                batt_ret.batt_quant_return = model.QuantityReturn;

                db.Batt_Return.Add(batt_ret);
                db.SaveChanges();
                int latestProdId = batt_ret.batt_return_id;
                TempData["status"] = "Battery Return Successfully Submitted";

            }



            catch (Exception ex)
            {
                throw ex;


            }
            return RedirectToAction("BattReturnIndex");
        }

    }

}