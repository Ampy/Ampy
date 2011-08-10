using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHU.Web.Models;
using System.Data.Common;

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
        public ActionResult QueryResult(string url)
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

        /// <summary>
        /// 课程表
        /// </summary>
        /// <returns></returns>
        public ViewResult Subject()
        {
            return View();
        }

        /// <summary>
        /// 根据课程表查询
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult Subject(FormCollection collection)
        {
            var jie = collection["Jie"];
            var kc = collection["KC"];
            
            var m = SHU.Arts.ArtsServices.GetArtsBy(jie,kc);
            return View("QueryResult", m);
        }

        /// <summary>
        /// 学生作品
        /// </summary>
        /// <returns></returns>
        public ViewResult Student()
        {
            var m = SHU.Arts.ArtsServices.GetAllArts();
            return View("Student", m);
        }

        /// <summary>
        /// 按届查询
        /// </summary>
        /// <param name="jie"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult Student(string jie)
        {
            return View();
        }

        public ViewResult KCQuery(string jie, string kc)
        {
            //var m = SHU.Arts.ArtsServices.g
        string connstr = "Data Source=|DataDirectory|\\StarterSite.sdf;Persist Security Info=False";
        string providerstr = "System.Data.SqlServerCe.4.0";

            DbProviderFactory dp = DbProviderFactories.GetFactory(providerstr);

            using (DbConnection conn = dp.CreateConnection())
            {
                conn.ConnectionString = connstr;
                //conn.Open();
                using (ArtDbContext db = new ArtDbContext(conn,true))
                {
                    List<ArtModel> m = db.Arts.ToList();//.Where(c => c.Jie == jie && c.KeCheng == kc);

                    return View(m);
                }
            }
   
            
           


        }
    }
}
