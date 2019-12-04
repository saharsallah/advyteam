using System;
using System.Collections.Generic;
using System.Web.Mvc;

using Newtonsoft.Json;

using System.Linq;
using Solution.Data;
using System.Net;

using System.IO;
using Solution.Web.Models;
using System.Net.Mail;

namespace Solution.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();            
        }
        public ActionResult EmployeHome()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<formation> lst = JsonConvert.DeserializeObject<IEnumerable<formation>>(responseString,
                                                      new MyDateTimeConverter());

            return View(lst);

        }

        public ActionResult Quiz(string type)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:18080/Piadvy-web/rest/formation/getquiz/"+type);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            IEnumerable<Quiz> lst = JsonConvert.DeserializeObject<IEnumerable<Quiz>>(responseString,
                                                      new MyDateTimeConverter());
            if (lst.ToList().Count() < 3)
                return View("QuizError");
            lst = lst.OrderBy(x => Guid.NewGuid()).Take(3);

            return View(lst);

        }

        [HttpPost]
        public ActionResult Quiz(bool rep1 , bool rep2, bool rep3)
        {
            try
            {

                int a = 0;
                a = rep1 ? a + 1 : a;
                a = rep2 ? a + 1 : a;
                a = rep3 ? a + 1 : a;
                int note = (int)(a*20/3);
				if(note > 10) { 
				var fromEmail = new MailAddress("nada.eladel@esprit.tn", "nada");
				var toEmail = new MailAddress("eladelnada11@gmail.com");
				var FromEmailPassword = "183JFT1717";

				string subject = "Formation validé avec succés";

				string body = "Compétence aquise" +
					"<br/><a href = '></a>";

				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(fromEmail.Address, FromEmailPassword),
					Timeout = 20000
				};
				using (var message = new MailMessage(fromEmail, toEmail)
				{
					Subject = subject,
					Body = body,
					IsBodyHtml = true

				}) smtp.Send(message);

				}
				return RedirectToAction("Note", new { note });

            }
            catch
            {
                return View("error");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Note(int note) {
            ViewBag.note = note;
            return View();
        }

        public ActionResult LogOut()
        {
            Session["user"] = null;
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}