using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Product_Management_System;
using Product_Management_System.Models;

namespace Product_Management_System.Controllers
{
    [Authorize]
    public class Products_ListController : Controller
    {
        private ProductManagementEntities db = new ProductManagementEntities();

        // GET: Products_List
        public ActionResult Index()
        {
            return View(db.Products_List.ToList());
        }

        // GET: Products_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_List products_List = db.Products_List.Find(id);
            if (products_List == null)
            {
                return HttpNotFound();
            }
            return View(products_List);
        }

        // GET: Products_List/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products_List/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_id,Name,Category,Quantity,Short_Description,Long_Description,Small_Image,Price")] Products_List products_List)
        {
            if (ModelState.IsValid)
            {
                db.Products_List.Add(products_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(products_List);
        }

        // GET: Products_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_List products_List = db.Products_List.Find(id);
            if (products_List == null)
            {
                return HttpNotFound();
            }
            return View(products_List);
        }

        // POST: Products_List/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_id,Name,Category,Quantity,Short_Description,Long_Description,Small_Image,Price")] Products_List products_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products_List);
        }

        // GET: Products_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_List products_List = db.Products_List.Find(id);
            if (products_List == null)
            {
                return HttpNotFound();
            }
            return View(products_List);
        }

        // POST: Products_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products_List products_List = db.Products_List.Find(id);
            db.Products_List.Remove(products_List);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
