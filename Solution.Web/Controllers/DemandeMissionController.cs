using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solution.Web.Controllers
{
    public class DemandeMissionController : Controller
    {
        // GET: DemandeMission
        public ActionResult Index()
        {
            return View();
        }

        // GET: DemandeMission/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemandeMission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemandeMission/Create
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

        // GET: DemandeMission/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemandeMission/Edit/5
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

        // GET: DemandeMission/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemandeMission/Delete/5
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
