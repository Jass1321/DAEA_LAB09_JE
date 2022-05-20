using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAEA_LAB09_JE.Models;

namespace DAEA_LAB09_JE.Controllers
{
    public class ProductController : Controller
    {
        
        // GET: Product
        public ActionResult Index()
        {
            /*
            productos.Add(new ProductModel { ProductID = 1, Name = "Jack&Jackie", Description = "T:19-21", Price = 99 });
            productos.Add(new ProductModel { ProductID = 2, Name = "Molekinha", Description = "T:17-25", Price = 89 });
            return View(productos);
            */

            if (Session["productos"] == null)
            {
                Session["productos"] =  new List<ProductModel>();
                ;
            }
            return View(Session["productos"]);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var model = ((List<ProductModel>)Session["productos"]).Where(x => x.ProductID == id).FirstOrDefault();
            return View(model);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            try
            {
                // TODO: Add insert logic here
                ((List<ProductModel>)Session["productos"]).Add(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var model = ((List<ProductModel>)Session["productos"]).Where(x => x.ProductID == id).FirstOrDefault();

            return View(model);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductModel model)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
