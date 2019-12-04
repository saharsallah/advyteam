using Solution.Domain.Entities;
using Solution.Service;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solution.Web.Controllers
{
    public class NoteDeFraisController : Controller
    {
        NoteDeFraisService s = new NoteDeFraisService();
        MissionService M = new MissionService();
        // GET: NoteDeFrais
        public ActionResult Index()
        {

            List<ModelNoteDeFrais> lq = new List<ModelNoteDeFrais>();
            foreach (var qm in s.GetAll())
            {
                ModelNoteDeFrais q = new ModelNoteDeFrais();
                q.id = qm.id;
                q.libelle = qm.libelle;
                q.montant = qm.montant;
                q.tauxderembourssement = qm.tauxderembourssement;
                q.Remboursable = qm.Remboursable;
                q.MissionId = qm.MissionId;
                lq.Add(q);

            }
            return View(lq);
        }

        // GET: NoteDeFrais/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoteDeFrais/Create
        public ActionResult Create()
        {
            var missions = M.GetAll();
            ViewBag.listprod = new SelectList(missions, "id", "libelle");
            return View();
        }

        // POST: NoteDeFrais/Create
        [HttpPost]
        public ActionResult Create(notefrai qm)
        {
            notefrai q = new notefrai();
            q.libelle = qm.libelle;
            q.montant = qm.montant;
            q.tauxderembourssement = qm.tauxderembourssement;
            q.Remboursable = qm.Remboursable;
            q.MissionId = qm.MissionId;
            s.Add(q);
            s.Commit();
            
            return RedirectToAction("Create");
        }

        // GET: NoteDeFrais/Edit/5
        public ActionResult Edit(int id)
        {

            notefrai t = s.GetById(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: NoteDeFrais/Edit/5
        [HttpPost]
        public ActionResult Edit( notefrai p)
        {
            notefrai m = s.GetById(p.id);
            m.id = p.id;
            m.libelle = p.libelle;
            m.montant = p.montant;
            m.tauxderembourssement = p.tauxderembourssement;
            m.Remboursable = p.Remboursable;
            m.MissionId = p.MissionId;
           

            if (ModelState.IsValid)
            {
                s.Update(m);
                s.Commit();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: NoteDeFrais/Delete/5
        public ActionResult Delete(int id)
        {
            return View(s.GetById(id));
        }

        // POST: NoteDeFrais/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,  notefrai q)
        {
            q = s.GetById(id);
            s.Delete(q);
            s.Commit();
            return RedirectToAction("Index");
        }
    }
}
