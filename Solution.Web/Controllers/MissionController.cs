using Solution.Data;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Solution.Web.Models;

namespace Solution.Web.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("Piadvy-web/Mission").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<mission>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();
        }

        // GET: Mission/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mission/Create
        [HttpPost]
        public ActionResult Create(ModelMission f)
        {
            employee e = new employee();
            e.id = 1;
            HttpClient client = new HttpClient();
            f.duree = null;
            f.etat = false;
            f.missionInternational = false;
            f.MissionReussit = false;
            f.emp = e;
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9080/Piadvy-web/Mission/new");
            string json = new JavaScriptSerializer().Serialize(new
            {
                libelle = f.libelle,
                description = f.description,
                duree = f.duree,
                etat = f.etat,
                emp = f.emp,


            }
                );
            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();
            return RedirectToAction("Index");
        }

        // GET: Mission/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mission/Edit/5
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

        // GET: Mission/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mission/Delete/5
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
