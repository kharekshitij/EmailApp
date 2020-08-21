using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using Appsierra_MailApp.Models;

namespace Appsierra_MailApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(EmailModel obj)
        {
            try
            {
                //Configuring webMail class to send emails
                //gmail smtp server
                WebMail.SmtpServer = "smtp.gmail.com";
                //gmail port to send emails
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                //sending emails with secure protocol
                WebMail.EnableSsl = true;
              
                //EmailId used to send emails from application
                WebMail.UserName = "YourGamilId@gmail.com";
                WebMail.Password = "YourGmailPassword";

                //Sender email address.
                WebMail.From = "SenderGamilId@gmail.com";

                //Send email
                WebMail.Send(to: obj.ToEmail, subject: obj.EmailSubject, body: obj.EMailBody, isBodyHtml: true);
                ViewBag.Status = "Email Sent Successfully.";
            }
            catch (Exception)
            {
                ViewBag.Status = "Problem while sending email, Please check details.";

            }
            return View();
        }
    }
}