using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.SqlClient;
using Salesapp.Models;
using System;


namespace Salesapp.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home

        public ActionResult ThankYou()
        {
            ViewBag.Message = "Successfull";
            return View();
        }
            public ActionResult Index()
        {
            SalesLayanEntities14 db = new SalesLayanEntities14();
            List<Product_Category> list = db.Product_Category.ToList();
            ViewBag.ProductName = new SelectList(list,"cat_id","cat_name");

            return View();
        }

        public ActionResult SaveRecord(ProductForm model)
        {
            try
            {
                SalesLayanEntities14 db = new SalesLayanEntities14();
                Product prod = new Product();

                prod.prod_name = model.Prod_name;
                prod.prod_model = model.Prod_model;
                prod.prod_quantity = model.Prod_quantity;
                prod.prod_description = model.Prod_description;
                prod.prod_unit_cost_price = model.Prod_unit_cost_price;
                prod.cat_id = model.Cat_id;


                db.Products.Add(prod);
                db.SaveChanges();
                int latestProdId = prod.prod_id;
                TempData["status"] = "Success";






            }

            catch (Exception ex)
            {
                throw ex;


            }
            return RedirectToAction("Index");
            


            }


    }
}