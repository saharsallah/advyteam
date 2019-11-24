using Solution.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Context = Solution.Data.Context;

namespace Solution.Web.Controllers
{
    public class ProjetController : Controller
    {
        Context context = new Context();

        // GET: Projet
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8080");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("/Piadvy-web/api/projets/1").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<projet>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(projet p)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080");
            client.PostAsJsonAsync<projet>("Piadvy-web/api/new", p).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            Console.WriteLine(p);
            return RedirectToAction("Index");
        }
    }
}