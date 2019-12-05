using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Send_Mail_Webapi.Models;
using System.Net.Http;

namespace Solution.Web.Controllers
{
    public class GmailsendController : Controller
    {
        // GET: Gmailsend
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmailClass ec)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44337/api/Email");
            var consumewebapi = hc.PostAsJsonAsync<EmailClass>("Email", ec);
            consumewebapi.Wait();

            var sendmail = consumewebapi.Result;
            if (sendmail.IsSuccessStatusCode)
            {
                ViewBag.message = "The Mail Has Been Sent To " + ec.to.ToString();
            }
            return View();
        }
    }
}