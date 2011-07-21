﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHU.Web.Controllers
{
    public class ArtsController : Controller
    {
        //
        // GET: /Arts/
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string url)
        {
            string nj=Request.Form["NJ"];
            string xq=Request.Form["XQ"];
            string kc=Request.Form["KC"];

            var m = SHU.Arts.ArtsServices.GetArtsBy(nj, xq, kc);
            return View("QueryResult",m);

        }

        //
        // GET: /Arts/Details/5

        public ActionResult Details(int id)
        {

            return View();
        }

        //
        // GET: /Arts/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Arts/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Arts/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Arts/Edit/5

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

        //
        // GET: /Arts/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Arts/Delete/5

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

        public ViewResult Subject()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Subject(FormCollection collection)
        {
            var p = collection[0];
            
            var m = SHU.Arts.ArtsServices.GetArtsBy("", "", "");
            return View("QueryResult", m);
        }
    }
}
