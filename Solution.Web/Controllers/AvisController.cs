using Service.Pattern;
using Solution.Domain.Entities;
using Solution.Service;
using Solution.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Solution.Web.Controllers
{
    public class AvisController : Controller
    {

        ServiceAvis s = new ServiceAvis();
        ServiceEmp e = new ServiceEmp();
            // GET: Avis
        public ActionResult Index()
        {/*
            List<ModelAvis> lq = new List<ModelAvis>();
            foreach (var qm in s.GetAll())
            {
                ModelAvis q = new ModelAvis();
                q.avis1 = qm.avis1;
                q.avis2 = qm.avis2;
                q.avis3 = qm.avis3;
                q.avis4 = qm.avis4;
                q.avis5 = qm.avis5;
                q.rep1 = qm.rep1;
                q.rep2 = qm.rep2;
                q.rep3 = qm.rep3;
                q.rep4 = qm.rep4;
                q.rep5 = qm.rep5;
                q.rep6 = qm.rep6;
                q.rep7 = qm.rep7;
                q.rep8 = qm.rep8;
                q.rep9 = qm.rep9;
                q.rep10 = qm.rep10;
                q.rep11 = qm.rep11;
                q.rep12 = qm.rep12;
                q.rep13 = qm.rep13;
                q.rep14 = qm.rep14;
                q.rep15 = qm.rep15;
                lq.Add(q);

            }
            return View(lq);*/
            List<ModelAvis> maliste = new List<ModelAvis>();
            IEnumerable<avis> avis = s.GetMany();

            foreach (var qm in avis)
            {
                maliste.Add(new ModelAvis
                {
                    id = qm.id,
                avis1 = qm.avis1,
                    avis2 = qm.avis2,
                    avis3 = qm.avis3,
                    avis4 = qm.avis4,
                    avis5 = qm.avis5,
                    rep1 = qm.rep1,
                    rep2 = qm.rep2,
                    rep3 = qm.rep3,
                    rep4 = qm.rep4,
                    rep5 = qm.rep5,
                    rep6 = qm.rep6,
                    rep7 = qm.rep7,
                    rep8 = qm.rep8,
                    rep9 = qm.rep9,
                    rep10 = qm.rep10,
                    rep11 = qm.rep11,
                    rep12 = qm.rep12,
                    rep13 = qm.rep13,
                    rep14 = qm.rep14,
                    rep15 = qm.rep15
                }); ;
            }
            return View(maliste);
        }

        // GET: Avis/Details/5
        public ActionResult Details(int id)
        {
            //var test = s.GetAvisById(id);
            List<ModelAvis> l = new List<ModelAvis>();
            foreach (var m in s.GetAvisById(id))
            {

                ModelAvis t = new ModelAvis();
                t.avis1 = m.avis1;
                t.avis2 = m.avis2;
                t.avis3 = m.avis3;
                t.avis4 = m.avis4;
                t.avis5 = m.avis5;
                t.rep1 = m.rep1;
                t.rep2 = m.rep2;
                t.rep3 = m.rep3;
                t.rep4 = m.rep4;
                t.rep5 = m.rep5;
                t.rep6 = m.rep6;
                t.rep7 = m.rep7;
                t.rep8 = m.rep8;
                t.rep9 = m.rep9;
                t.rep10 = m.rep10;
                t.rep11 = m.rep11;
                t.rep12 = m.rep12;
                t.rep13 = m.rep13;
                t.rep14 = m.rep14;
                t.rep15 = m.rep15;
                l.Add(t);
            }
            return View(l);



        }
        [HttpPost]
        public ActionResult Details()
        {
            return RedirectToAction("Details");

        }

        // GET: Avis/Create
        public ActionResult Create()
        {

            var employes = e.GetMany();
            ViewBag.listprod = new SelectList(employes, "id", "nom");
            return View();
        }

        // POST: Avis/Create
        [HttpPost]
        public ActionResult Create(ModelAvis a)
        {
            avis av = new avis();

            av.avis1 = a.avis1;
            av.avis2 = a.avis2;
            av.avis3 = a.avis3;
            av.avis4 = a.avis4;
            av.avis5 = a.avis5;
            av.rep1 = a.rep1;
            av.rep2 = a.rep2;
            av.rep3 = a.rep3;
            av.rep4 = a.rep4;
            av.rep5 = a.rep5;
            av.rep6 = a.rep6;
            av.rep7 = a.rep7;
            av.rep8 = a.rep8;
            av.rep9 = a.rep9;
            av.rep10 = a.rep10;
            av.rep11 = a.rep11;
            av.rep12 = a.rep12;
            av.rep13 = a.rep13;
            av.rep14 = a.rep14;
            av.rep15 = a.rep15;
            av.etat = a.etat;
            av.idEmplye = a.idEmplye;


            s.Add(av);
            s.Commit();
             
        
            avis p1 = s.GetById(av.id);
            p1.rep15 = av.rep15;


            if (ModelState.IsValid)
            {
                s.Update(p1);
                s.Commit();
                var verifyurl = "/Signup/VerifiyAccount/";
                var link = Request.Url.AbsolutePath.Replace(Request.Url.PathAndQuery, verifyurl);

                var fromEmail = new MailAddress("fatma.dayeg@esprit.tn", "AdvyTeam");
                var toEmail = new MailAddress("saharsallah6@gmail.com");
                var FromEmailPassword = "172jft1681";

                string subject = "Response On Formation Application";

                string body = "! Go check your Result. " +
                    "<br/><a href = '" + link + "'>" + link + "</a>";

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
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        
            

        }


        // GET: Avis/Edit/5
        public ActionResult Edit(int id)
        {
            avis a = s.GetById(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // POST: Avis/Edit/5
        [HttpPost]
        public ActionResult Edit(avis a)
        {
            avis x = s.GetById(a.id);
            x.avis1 = a.avis1;
            x.avis2 = a.avis2;
            x.avis3 = a.avis3;
            x.avis4 = a.avis4;
            x.avis5 = a.avis5;
            x.rep1 = a.rep1;
            x.rep2 = a.rep2;
            x.rep3 = a.rep3;
            x.rep4 = a.rep4;
            x.rep5 = a.rep5;
            x.rep6 = a.rep6;
            x.rep7 = a.rep7;
            x.rep8 = a.rep8;
            x.rep9 = a.rep9;
            x.rep10 = a.rep10;
            x.rep11 = a.rep11;
            x.rep12 = a.rep12;
            x.rep13 = a.rep13;
            x.rep14 = a.rep14;
            x.rep15 = a.rep15;
            x.etat = a.etat;

            if (ModelState.IsValid)
            {
                s.Update(x);
                s.Commit();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: Avis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Avis/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, avis a )
        {
            a = s.GetById(id);
            s.Delete(a);
            s.Commit();
            return RedirectToAction("Index");
        }
       

    }
}
