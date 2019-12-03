using Solution.Data;
using Solution.Domain.Entities;
using Solution.Service;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
            IEnumerable<reclamation> lstRecl = service.Getrec();
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
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:9080");
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            reclamation r = service.Get(f => f.Id == id);
            HttpResponseMessage responce = Client.GetAsync("Piadvy-web/employe/emp?id=" + r.EmployeeId).Result;
            return View(r);
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
                //EmployeeId = (int)Session["emp4"]
            };
            int idemp = (int)Session["emp4"];
            employee emp = serviceemp.GetById(idemp);
            emp.Reclamations.Add(r);
            serviceemp.Commit();

            return RedirectToAction("Index");
            //return View();
        }
        // GET: Reclamation/Edit/5
        public ActionResult Edit(int id)
        {
            reclamation r = service.Get(f => f.Id == id);
            employee emp = serviceemp.GetById((int)r.EmployeeId);
            //int idemp = (int)Session["emp4"];         
            EmployeeModel E = new EmployeeModel
            {
                adresse = emp.adresse,
                nom = emp.nom,
                prenom = emp.prenom,
                sexe = emp.sexe,
                datenaissance = emp.datenaissance,
                etatcivil = emp.etatcivil,
                Type_emp = emp.Type_emp
            };
            return View(E);
        }

        // POST: Reclamation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeModel employeeModel)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, "http://localhost:9080/Piadvy-web/employe");
            reclamation r = service.Get(f => f.Id == id);
            employee emp = serviceemp.GetById((int)r.EmployeeId);
            String dateString = "yyyy/mm/dd";

            string json = new JavaScriptSerializer().Serialize(new
            {
                id = emp.id,
                nom = employeeModel.nom,
                prenom = employeeModel.prenom,
                adresse = employeeModel.adresse,
                datenaissance = Convert.ToDateTime(employeeModel.datenaissance).ToString("yyyy-MM-dd"),
                etatcivil = employeeModel.etatcivil,
                sexe = employeeModel.sexe
            });

            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();

            String email = (String)emp.email;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("porjet2019@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Test Mail";
            mail.Body = "Votre Reclamation Est  traite MR/MM " + employeeModel.nom + " " + " " + employeeModel.prenom;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("porjet2019@gmail.com", "duwhjaxubkjxebih");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);


            r.Etat = true;
            r.DateTraitement = DateTime.Now;
            foreach (reclamation rec in emp.Reclamations)
            {
                if (rec.Id == r.Id)
                {
                    rec.Etat = true;
                    rec.DateTraitement = DateTime.Now;
                }
            }
           // serviceemp.Update(emp);
            serviceemp.Commit();
            //     service.Commit();
            return RedirectToAction("Index");
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

        public ActionResult Mesreclamation()
        {
            int idemp = (int)Session["emp4"];
            IEnumerable<reclamation> lstRecl = service.GetMesrec(idemp);
           
            int j =0;
         
            double[] M = new double[lstRecl.Count()];
            foreach (var rec in lstRecl)
            {
                if (rec.DateTraitement==null)
                {
                    ViewBag.res = rec.DateReclamation;
                }
                else
                {     
                    TimeSpan t = (DateTime)rec.DateTraitement - (DateTime)rec.DateReclamation;
                    
                    M[j++] = t.Days ;

                }
            }           
            ViewBag.res2 = M;
            return View(lstRecl) ;
        }

        public ActionResult Addnoterec(int id,int idrec) 
        { 
           reclamation r = service.Get(f => f.Id == idrec);
            r.note = id;
           employee e = serviceemp.Get(f => f.id == r.EmployeeId);

            foreach (reclamation rec in e.Reclamations)
            {
                if (rec.Id == r.Id)
                {
                 rec.note = id;
               }
            }

            serviceemp.Commit();
            return RedirectToAction("Mesreclamation");
        }
        public int Nbrrec() 
        {
            int a = service.Getreclamationnontraite();
            return a;

        }
    }
}
