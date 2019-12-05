﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Send_Mail_Webapi.Models;
using System.Net.Mail;

namespace Solution.Web.Controllers
{
    public class EmailController : ApiController
    {
        public IHttpActionResult sendmail(EmailClass ec)
        {
            string subject = ec.subject;
            string body = ec.body;
            string to = ec.to;

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("ateef.jlassi@gmail.com");
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = true;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ateef.jlassi@gmail.com", "ya allah ya karim");
            smtp.Send(mm);
            return Ok();

        }
    }
}
