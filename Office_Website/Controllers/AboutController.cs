using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Office_Website.Models.Class;

namespace Office_Website.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context cl = new Context();
        AboutTopic at = new AboutTopic();
        public ActionResult Index()
        {
            ViewBag.Title = "Avukat Miraç Yılmaz || Hakkımızda";
            at.Deger1 = cl.Abouts.ToList();
            at.Deger2 = cl.Topic.ToList();
            return View(at);
        }
    }
}