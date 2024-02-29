//This is code is written by Naheem Olaniyan

using Salesapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salesapp.Controllers
{
    public class AddBatteryController : Controller
    {
        // GET: AddyBattery
        public ActionResult BattAddIndex()
        {
            //Dropdownlist
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Terminal> list = db.Terminals.ToList();
            ViewBag.TerminalName = new SelectList(list, "terminal_id", "terminal_name");

            List<Size> liste = db.Sizes.ToList();
            ViewBag.SizeName = new SelectList(liste, "size_id", "size1");


            List<Height> listq = db.Heights.ToList();
            ViewBag.HeightName = new SelectList(listq, "height_id", "height_name");

            
            List<Supplier> listw = db.Suppliers.ToList();
            ViewBag.SupplierName = new SelectList(listw, "supplier_id", "supplier_name");

            return View();
        }

        public ActionResult BattAddSave(AddyBattery model)
        {
            try
            {
                //Assigning the data value
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Battery addBatt = new Battery();

                addBatt.terminal_id = model.Terminal_id;
                addBatt.supplier_id = model.Supplier_id;
                addBatt.height_id = model.Height_id;
                addBatt.batt_id = model.Batt_id;
                addBatt.Batt_quantity = model.Batt_quantity;
                addBatt.size_id= model.Size_id;
                addBatt.Batt_Unit_Price = model.Batt_Unit_Price;
                addBatt.Date = model.Date;
                addBatt.Batt_description = model.Batt_description;

                db.Batteries.Add(addBatt);
                db.SaveChanges();
                int latestProdId = addBatt.batt_id;
                TempData["status"] = "Success";

            }


            catch (Exception ex)
            {
                throw ex;


            }
            //return back to the index page
            return RedirectToAction("BattAddIndex");
        }
    }
}