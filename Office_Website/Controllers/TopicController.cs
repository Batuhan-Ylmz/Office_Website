using Office_Website.Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Office_Website.Controllers
{
    public class TopicController : Controller
    {
        Context c = new Context();
        TopicBlog tp = new TopicBlog();
        // GET: Topic
        public ActionResult Index()
        {
            ViewBag.Title = "Avukat Miraç Yılmaz || Çalışma Alanlarımız";
            var x = c.Topic.ToList();
            return View(x);
        }
        public ActionResult Topicdetail(int id)
        {
            tp.Deger1 = c.Topic.Where(x => x.Id == id).ToList();
            tp.Deger2 = c.Blogs.Where(x => x.Id == id).OrderByDescending(x => x.Id).ToList();

            return View(tp);
        }
        public ActionResult Topictitles()
        {
            var titles = c.Topic.ToList();
            return View(titles);
        }
    }
}