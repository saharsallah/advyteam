﻿using Solution.Data;
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
    public class EmployeController : Controller
    {

        IEmployeeService serviceemp;
        IReclamationService service;
        public EmployeController()
        {
            serviceemp = new EmployeeService();
            service = new ReclamationService();

        }
        employee emp;

        // GET: Employe
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responce = Client.GetAsync("Piadvy-web/employe").Result;
            if (responce.IsSuccessStatusCode)
            {
                ViewBag.result = responce.Content.ReadAsAsync<IEnumerable<employee>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();
        }

        // GET: Employe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employe/Create
        [HttpPost]
        public ActionResult Create(LoginModel loginModel)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responce = Client.GetAsync("Piadvy-web/employe/login?login=" + loginModel.email + "&pass=" + loginModel.password).Result;
            emp = responce.Content.ReadAsAsync<employee>().Result;
            employee em;
            em = serviceemp.GetById(emp.id);
            int a = service.Getreclamationnontraite();
          
            Session["notif"] = a;

            EmployeeModel E = new EmployeeModel
            {
                adresse = em.adresse,
                id = em.id,
                nom = em.nom,
                image = em.image,
                isActif = em.isActif,
                datenaissance = em.datenaissance,
                etatcivil = em.etatcivil,
                Type_emp=em.Type_emp
            };
            

            Session["emp"] = em.Type_emp;
            Session["EmployeeConnecte"] = E;
            if (em.Type_emp.Equals("devloppeur"))
            {
                Session["emp"] = emp.nom;
                Session["emp2"] = emp.prenom;
                Session["emp3"] = emp.image;
                Session["emp4"] = emp.id;
                Session["emp5"] = emp.email;
                return Redirect("~/Home/About");
               
            }
            else
            {
                Session["emp4"] = emp.id;
                return Redirect("~/Reclamation/Index");
               
            }

        
        }

        // GET: Employe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employe/Edit/5
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

        // GET: Employe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employe/Delete/5
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


        public ActionResult LogOff()
        {
            Session.Contents.RemoveAll();
            return Redirect("~/Employe/Create");
        }
    }
}
