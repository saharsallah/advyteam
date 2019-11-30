using Solution.Data;
using Solution.Domain.Entities;
using Solution.Service;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Solution.Web.Controllers
{
    public class ReclamationController : Controller
    {

        IEmployeeService serviceemp;
        IReclamationService service;


        employee e;

        public ReclamationController()
    {
        service = new ReclamationService();
        serviceemp = new EmployeeService();
    }

     // GET: Reclamation
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            service = new ReclamationService();

            IEnumerable<reclamation> lstRecl = service.GetMany();
            foreach (var rec in lstRecl)
            {
                HttpResponseMessage responce = Client.GetAsync("Piadvy-web/employe/emp?id=" + rec.EmployeeId).Result;
                rec.employee = responce.Content.ReadAsAsync<employee>().Result;

                

            }
            return View(lstRecl);
        }

        // GET: Reclamation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reclamation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reclamation/Create
        [HttpPost]
        public ActionResult Create(ReclamationModel reclamationModel)
        {
            reclamation r = new reclamation
            {
                Objet = reclamationModel.Objet,
                Description = reclamationModel.Description,
                DateReclamation = DateTime.Now,
                DateTraitement = null,
                Etat = false,
                EmployeeId = (int)Session["emp4"]
            };    
            service.Add(r);
            service.Commit();
                return RedirectToAction("Create");
            //return View();
        }


        // GET: Reclamation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reclamation/Edit/5
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

        // GET: Reclamation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reclamation/Delete/5
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
