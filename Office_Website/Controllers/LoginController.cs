using Office_Website.Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Office_Website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Admin ad)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", ad);
            }
            var admin = c.Admins.FirstOrDefault(x => x.UserName == ad.UserName && x.password == ad.password);
            if (admin != null)
            {
                FormsAuthentication.SetAuthCookie(admin.UserName, ad.remME);
                Session["Kullanici"] = admin;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Message = "Girdiğniz Bilgiler Hatalıdır";
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}