using Solution.Data;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8080/Piadvy-web/api/new");
            string json = new JavaScriptSerializer().Serialize(new
            {
                description = p.description,
                titre = p.titre,
                //createdBy = 2,
                //dateDebut = p.dateDebut,
                //deadline = p.deadline
            }
            );

            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();


            //client.BaseAddress = new Uri("http://localhost:8080");
            //client.PostAsJsonAsync<projet>("Piadvy-web/api/new", p).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            //Console.WriteLine(p);
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/Piadvy-web/");
            client.DeleteAsync("api/delete/" + id).ContinueWith((deleteTask) => deleteTask.Result.EnsureSuccessStatusCode());

            return RedirectToAction("Index", "Index");
        }
    }
}