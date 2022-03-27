using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Office_Website.Models.Class;

namespace Office_Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Context c = new Context();
        BlogComments bc = new BlogComments();
        public ActionResult Index(int? id)
        {
            ViewBag.Title = "Avukat Miraç Yılmaz";
            ViewBag.user = id;
            return View();
        }
        public ActionResult slider()
        {
            return View();
        }
        public ActionResult info()
        {
            var values = c.Addresses.ToList();
            return View(values);
        }
        Context cl = new Context();
        public ActionResult About()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }
        public ActionResult blog()
        {
            bc.Deger1 = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(bc);
        }
        public PartialViewResult Menu()
        {
            var ChargeTypes = c.Topic.ToList();
            return PartialView(ChargeTypes);
        }
    }
}