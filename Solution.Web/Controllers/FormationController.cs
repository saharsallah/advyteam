using System;
using System.Collections.Generic;
using System.Web.Mvc;

using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Linq;
using Solution.Data;
using System.Net;

using System.IO;
using Solution.Service;
using System.Globalization;
using System.Web.Script.Serialization;
using Solution.Web.Models;

namespace Solution.Web.Controllers
{
    public class FormationController : Controller
    {
        FormationService fs = new FormationService();

        // GET: Formation
        public ActionResult Index()
        {

            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<formation> lst = JsonConvert.DeserializeObject<IEnumerable<formation>>(responseString,
                                                      new MyDateTimeConverter());

            return View(lst);
        }

        // GET: Formation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Formation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formation/Create
        [HttpPost]
        public ActionResult Create(formation f)
        {
            try
            {

                var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
                request.Method = "POST";
                request.ContentType = "application/json";
                string Data = JsonConvert.SerializeObject(f);
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                request.ContentLength = sentData.Length;

                using (Stream sendStream = request.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();

                }
                var response = (HttpWebResponse)request.GetResponse();

                return RedirectToAction("Index");
            }
            catch
            {
                return View("error");
            }
        }

        // GET: Formation/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: Formation/Edit/5
        [HttpPost]
        public ActionResult Edit( formation f)
        {
            try
            {
            
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
                request.Method = "PUT";
                request.ContentType = "application/json";
                string Data = JsonConvert.SerializeObject(f);
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                request.ContentLength = sentData.Length;

                using (Stream sendStream = request.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();

                }
                var response = (HttpWebResponse)request.GetResponse();

                return RedirectToAction("Index");
            }
            catch
            {
                return View("error");
            }
        }

        // GET: Formation/Delete/5
        public ActionResult Delete(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation/" + id);
            request.Method = "DELETE";
            var response = (HttpWebResponse)request.GetResponse();
            var action = (response.StatusCode == HttpStatusCode.OK) ? (ActionResult)RedirectToAction("Index")  : View("error");
            return action;  
        }
        // POST: Formation/Create
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            employee e = fs.login(email, password);
            if(e == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Session["user"] = e;
                if(e.Type_emp == "admin")
                    return RedirectToAction("Index");
                else
                    return RedirectToAction("EmployeHome", "Home");
            
        }
        public ActionResult Stat()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<formation> lst = JsonConvert.DeserializeObject<IEnumerable<formation>>(responseString,
                                                      new MyDateTimeConverter());
            var model =
            new optionsViewModel
            {
                Janvier = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 1 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Fevrier = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 2 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Mars = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 3 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Avril = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 4 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Mai = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 5 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Juin = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 6 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Juillet = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 7 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Aout = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 8 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Septembre = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 9 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Octobre = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 10 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Novembre = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 11 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
                Decembre = lst.ToList().FindAll(a => a.dateDebut.Value.Month == 12 && a.dateDebut.Value.Year == DateTime.Now.Year).ToList().Count(),
            };
            return View(model);

        }

        public ActionResult AjouterQuiz()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<formation> lst = JsonConvert.DeserializeObject<IEnumerable<formation>>(responseString,
                                                      new MyDateTimeConverter());
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach(formation iterator in lst)
            {
                listItems.Add(new SelectListItem
                {
                    Text = iterator.type,
                    Value = iterator.type
                });
            }
            ViewBag.listItems = listItems;
            return View();
            
      
        }
        [HttpPost]
        public ActionResult AjouterQuiz(Quiz f)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation/addQuiz");
                request.Method = "POST";
                request.ContentType = "application/json";
                string Data = JsonConvert.SerializeObject(f);
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                request.ContentLength = sentData.Length;

                using (Stream sendStream = request.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();

                }
                var response = (HttpWebResponse)request.GetResponse();

                return RedirectToAction("GetAllQuiz");
            }
            catch
            {
                return View("error");
            }
        }
        public ActionResult GetAllQuiz()
        {

            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation/allQuiz");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<Quiz> lst = JsonConvert.DeserializeObject<IEnumerable<Quiz>>(responseString,
                                                      new MyDateTimeConverter());
            return View(lst);
        }

    }
}
