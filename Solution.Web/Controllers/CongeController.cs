
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
    public class CongeController : Controller
    {
        ICongeService service;

        public CongeController()
        {
            service = new CongeService();
        }


        // GET: Conge
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conge/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conge/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conge/Create
        [HttpPost]
        public ActionResult Create(conge conge)
        {
           /* conge conge = new conge
            {
                dateDebut = congeVM.dateDebut,
                dateFin = congeVM.dateFin,
                typeConge = congeVM.typeConge,
                valider = congeVM.valider,
                employe_id = congeVM.employe_id
            };
*/            
            service.Add(conge);
            service.Commit();
            return View();
        }

        // GET: Conge/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conge/Edit/5
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

        // GET: Conge/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conge/Delete/5
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
