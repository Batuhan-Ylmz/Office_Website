using Office_Website.Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Office_Website.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        ContatcMe cm = new ContatcMe();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Avukat Ahmet Mahmut || İletişim";
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact model)
        {
            MailMessage mymail = new MailMessage();
            mymail.To.Add("yourmail@gmail.com");
            mymail.From = new MailAddress("yourmal@gmail.com");
            mymail.Body = "<h3>" + model.AD + "</h3> Adli kişiden bir adet mesajınız var: <br>" + "<h2>" + model.Mesaj + "</h2> <br> Kişi İletşim Bilgileri: <br> Email = " + model.Mail + "<br> İsim = " + model.AD ;
            mymail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            
            smtp.Credentials = new NetworkCredential("yourmail", "yourpassword");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;


            try
            {
                smtp.Send(mymail);
                TempData["Message"] = "Mesajınız İletilmiştir. En kısa zamanda mail adresinize geri dönüş yapılacaktır.";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Girdiğiniz bilgiler iletilemedi. Hata Nedeni:" + ex.Message;
            }




            return RedirectToAction("Index", "Contact", TempData);
        }
        public PartialViewResult GetInfo()
        {
            var value = c.Addresses.ToList();
            return PartialView(value);
        }
    }

}