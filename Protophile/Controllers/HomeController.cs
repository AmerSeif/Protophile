using Protophile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Protophile.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();




        public ActionResult Index()
        {
            Homeviewmodel model = new Homeviewmodel
            {
                Owner = db.Owners.FirstOrDefault(),
                ProtofolioItem = db.ProtofolioItems.ToList(),
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

      [HttpPost]
        public ActionResult Contact( ContactModel Contact)
        {
            var Mail = new MailMessage();
            var LoginInfo = new NetworkCredential("amersanto4@gmail.com","0920809180");
            Mail.From = new MailAddress(Contact.Email);
            Mail.To.Add(new MailAddress("amersanto4@gmail.com"));
            Mail.Body = Contact.Message;



            var smtpClint = new SmtpClient("smtp.gmail.com",587);
            
            smtpClint.EnableSsl = true;
            smtpClint.Credentials = LoginInfo;
            smtpClint.Send(Mail);
            return View();
        }
    }
}