using Protophile.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protophile.Controllers
{
    public class ProtofolioItemsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ProtofolioItems
        public ActionResult Index()
        {

            return View(db.ProtofolioItems.ToList());
        }

        // GET: ProtofolioItems/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ProtofolioItems.Find(id));
        }

        // GET: ProtofolioItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProtofolioItems/Create
        [HttpPost]
        public ActionResult Create(ProtofolioItem protofolioItem , HttpPostedFileBase Upload)
        {

            string path = Path.Combine(Server.MapPath("~/Uploads"), Upload.FileName);
            Upload.SaveAs(path);
            protofolioItem.Image = Upload.FileName;
            db.ProtofolioItems.Add(protofolioItem);
            db.SaveChanges();

          return RedirectToAction("Index");
            
         
        }

        // GET: ProtofolioItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ProtofolioItems.Find(id));
        }

        // POST: ProtofolioItems/Edit/5
        [HttpPost]
        public ActionResult Edit(ProtofolioItem protofolioItemVM, HttpPostedFileBase Upload)
        {
            // TODO: Add update logic here

            ProtofolioItem protofolioItem = db.ProtofolioItems.Find(protofolioItemVM.Id);
            protofolioItem.ProtofolioName = protofolioItemVM.ProtofolioName;
            protofolioItem.Description = protofolioItemVM.Description;
            if (Upload != null)
            {
                if (!string.IsNullOrEmpty(Upload.FileName))
                {
                    protofolioItem.Image = Upload.FileName;
                    string path = Path.Combine(Server.MapPath("~/Uploads"), Upload.FileName);
                    Upload.SaveAs(path);
                }
            }
            db.Entry(protofolioItem).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
       
        }

        // GET: ProtofolioItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ProtofolioItems.Find(id));
        }

        // POST: ProtofolioItems/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            // TODO: Add delete logic here
            ProtofolioItem protofolioItem = db.ProtofolioItems.Find(id);
            db.ProtofolioItems.Remove(protofolioItem);
            db.SaveChanges();

                return RedirectToAction("Index");
          
        }
    }
}
