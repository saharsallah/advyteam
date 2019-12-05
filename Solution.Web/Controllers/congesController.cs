using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Solution.Data;
using Solution.Domain.Entities;

namespace Solution.Web.Controllers
{
    public class congesController : Controller
    {
        private Context db = new Context();

        // GET: conges
        public ActionResult Index()
        {
            var conges = db.conges.Include(c => c.employee);
            return View(conges.ToList());
        }

        // GET: conges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conge conge = db.conges.Find(id);
            if (conge == null)
            {
                return HttpNotFound();
            }
            return View(conge);
        }

        // GET: conges/Create
        public ActionResult Create()
        {
            ViewBag.employe_id = new SelectList(db.employees, "id", "type_emp");
            return View();
        }

        // POST: conges/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,dateDebut,dateFin,typeConge,valider,employe_id")] conge conge)
        {
            if (ModelState.IsValid)
            {

                db.conges.Add(conge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employe_id = new SelectList(db.employees, "id", "type_emp", conge.employe_id);
            return View(conge);
        }

        // GET: conges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conge conge = db.conges.Find(id);
            if (conge == null)
            {
                return HttpNotFound();
            }
            ViewBag.employe_id = new SelectList(db.employees, "id", "type_emp", conge.employe_id);
            return View(conge);
        }

        // POST: conges/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,dateDebut,dateFin,typeConge,valider,employe_id")] conge conge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employe_id = new SelectList(db.employees, "id", "type_emp", conge.employe_id);
            return View(conge);
        }

        // GET: conges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conge conge = db.conges.Find(id);
            if (conge == null)
            {
                return HttpNotFound();
            }
            return View(conge);
        }

        // POST: conges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            conge conge = db.conges.Find(id);
            db.conges.Remove(conge);
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
