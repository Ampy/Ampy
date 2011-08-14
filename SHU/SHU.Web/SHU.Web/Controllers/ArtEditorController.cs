using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHU.Web.Models;

namespace SHU.Web.Controllers
{ 
    public class ArtEditorController : Controller
    {
        private ArtDbContext db = new ArtDbContext();

        //
        // GET: /ArtEditor/

        public ViewResult Index()
        {
            var arts = db.Arts.Include(a => a.KeCheng).Include(a => a.NianJi).Include(a => a.XueQi);
            return View(arts.ToList());
        }

        //
        // GET: /ArtEditor/Details/5

        public ViewResult Details(Guid id)
        {
            ArtModel artmodel = db.Arts.Find(id);
            return View(artmodel);
        }

        //
        // GET: /ArtEditor/Create

        public ActionResult Create()
        {
            ViewBag.KeChengId = new SelectList(db.KeChengBiao, "KeChengId", "MingCheng");
            ViewBag.NianJiId = new SelectList(db.NianJiBiao, "NianJiId", "MingCheng");
            ViewBag.XueQiId = new SelectList(db.XueQiBiao, "XueQiId", "MingCheng");
            return View();
        } 

        //
        // POST: /ArtEditor/Create

        [HttpPost]
        public ActionResult Create(ArtModel artmodel)
        {
            if (ModelState.IsValid)
            {
                artmodel.ID = Guid.NewGuid();
                db.Arts.Add(artmodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.KeChengId = new SelectList(db.KeChengBiao, "KeChengId", "MingCheng", artmodel.KeChengId);
            ViewBag.NianJiId = new SelectList(db.NianJiBiao, "NianJiId", "MingCheng", artmodel.NianJiId);
            ViewBag.XueQiId = new SelectList(db.XueQiBiao, "XueQiId", "MingCheng", artmodel.XueQiId);
            return View(artmodel);
        }
        
        //
        // GET: /ArtEditor/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            ArtModel artmodel = db.Arts.Find(id);
            ViewBag.KeChengId = new SelectList(db.KeChengBiao, "KeChengId", "MingCheng", artmodel.KeChengId);
            ViewBag.NianJiId = new SelectList(db.NianJiBiao, "NianJiId", "MingCheng", artmodel.NianJiId);
            ViewBag.XueQiId = new SelectList(db.XueQiBiao, "XueQiId", "MingCheng", artmodel.XueQiId);
            return View(artmodel);
        }

        //
        // POST: /ArtEditor/Edit/5

        [HttpPost]
        public ActionResult Edit(ArtModel artmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KeChengId = new SelectList(db.KeChengBiao, "KeChengId", "MingCheng", artmodel.KeChengId);
            ViewBag.NianJiId = new SelectList(db.NianJiBiao, "NianJiId", "MingCheng", artmodel.NianJiId);
            ViewBag.XueQiId = new SelectList(db.XueQiBiao, "XueQiId", "MingCheng", artmodel.XueQiId);
            return View(artmodel);
        }

        //
        // GET: /ArtEditor/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            ArtModel artmodel = db.Arts.Find(id);
            return View(artmodel);
        }

        //
        // POST: /ArtEditor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            ArtModel artmodel = db.Arts.Find(id);
            db.Arts.Remove(artmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}