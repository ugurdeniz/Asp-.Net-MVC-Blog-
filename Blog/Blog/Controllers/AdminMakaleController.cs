using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class AdminMakaleController : Controller
    {
        mvcBlogDB db = new mvcBlogDB();
        // GET: AdminMakale
        public ActionResult Index()
        {
            var makales = db.Makales.ToList();
            return View(makales);
        }

        // GET: AdminMakale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminMakale/Create
        public ActionResult Create()
        {
            /*ViewBag.KategoriId = new SelectList(db.Kategoris, "KategoriId", "KategoriAdı");*/

           
            return View();
            ViewBag.KategoriId = db.Kategoris.Select(x => new SelectListItem { Text = x.KategoriAdı, Value = x.KategoriId.ToString() }).ToList(); 
            
        }

        // POST: AdminMakale/Create
        [HttpPost]
        public ActionResult Create(Makale makale, string etiketler, HttpPostedFileBase Foto)
        {
            try
            {
                db.Makales.Add(makale);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminMakale/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminMakale/Edit/5
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

        // GET: AdminMakale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminMakale/Delete/5
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
