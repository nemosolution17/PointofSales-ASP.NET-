//This code is written by Naheem Olaniyan

using Salesapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salesapp.Controllers
{
    public class AddyRimsController : Controller
    {
        // GET: AddyRims
        public ActionResult AddyRimIndex()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14 ();
            List<Rim_hub> list = db.Rim_hub.ToList();
            ViewBag.HubName = new SelectList(list, "hub_id", "hub_name");

            List<Rim_size> liste = db.Rim_size.ToList();
            ViewBag.SizeNo = new SelectList(liste, "size_id", "size_number");

            List<Rim_Type> listp = db.Rim_Type.ToList();
            ViewBag.TypeName = new SelectList(listp, "type_id", "type_name");

            List<Rim_Peg> listj = db.Rim_Peg.ToList();
            ViewBag.PegNo = new SelectList(listj, "peg_id", "peg_no");



            return View();
        }

        public ActionResult AddyRimSave(AddyRim model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Rim addRim = new Rim();

                addRim.peg_id = model.Peg_id;
                addRim.hub_id = model.Hub_id;
                addRim.type_id = model.Type_id;
                addRim.size_id = model.Size_id;
                addRim.Date = model.Date;
                addRim.Rim_description = model.Rim_description;
                addRim.Rim_quantity = model.Rim_quantity;
                addRim.Rim_unit_price = model.Rim_unit_price;
                

                db.Rims.Add(addRim);
                db.SaveChanges();
                int latestProdId = addRim.rim_id;
                TempData["status"] = "Success";

            }


            catch (Exception ex)
            {
                throw ex;


            }

            return RedirectToAction("AddyRimIndex");
        }
    }
}