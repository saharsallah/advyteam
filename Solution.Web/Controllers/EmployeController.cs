using Solution.Data;
using Solution.Service;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;

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


        
        public ActionResult Pagepassword()
        {
      

            return View();
        }


        public ActionResult Npass(MailEmployee mailEmployee)
        {
          
            employee e = serviceemp.Get(f => f.email.Equals(mailEmployee.email));
            
            e.password =MD5Hash("0000");

            String email = e.email;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("porjet2019@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Votre nouvau password";
            mail.Body = "Votre nouvau password:0000 est votre Mail est: "+e.email;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("porjet2019@gmail.com", "duwhjaxubkjxebih");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            serviceemp.Update(e);
            serviceemp.Commit();

            return Redirect("~/Employe/Create");
        }

        
            public static string MD5Hash(string text)
            {
                MD5 md5 = new MD5CryptoServiceProvider();

              
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

                //get hash result after compute it  
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }
        
       
    }
}
