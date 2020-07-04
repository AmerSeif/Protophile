using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Protophile.Models;


namespace Protophile.Controllers
{
    public class OwnersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Owners
        public ActionResult Index()
        {
            return View(db.Owners.ToList());
        }

        // GET: Owners/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Owners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owners/Create
        [HttpPost]
        public ActionResult Create(Owner owner ,HttpPostedFileBase Pic)
        {
            string path = Path.Combine(Server.MapPath("~/PicAv"), Pic.FileName);
            Pic.SaveAs(path);
            owner.Avatar = Pic.FileName;
            db.Owners.Add(owner);
            db.SaveChanges();

            return RedirectToAction("Index");

        
        }
        public ActionResult Proto()
        {
            

            return View(db.Owners.Where(a=>a.Id==1));
        }



        // GET: Owners/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Owners/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Owners/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Owners/Delete/5
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
