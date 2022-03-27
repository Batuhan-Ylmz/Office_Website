using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Office_Website.Models.Class;
using PagedList;

namespace Office_Website.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogComments bc = new BlogComments();

        public ActionResult Index(int? page)
        { //var blogss = c.Blogs.ToList();
            int pageNumber = page ?? 1;
            int pageSize = 6;
            var value = c.Blogs.OrderByDescending(x => x.Id).ToPagedList(pageNumber, pageSize);
            ViewBag.Title = "Avukat Miraç Yılmaz || Bloglarımız";
            return View(value);
        }
        public ActionResult Titles()
        {
            var titles = c.Topic.ToList();
            return View(titles);
        }
        public ActionResult Popular()
        {
            bc.Deger1 = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(bc);
        }
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Blogdetail(int id)
        {
            bc.Deger1 = c.Blogs.Where(x => x.Id == id).ToList();
            bc.Deger2 = c.Comments.Where(x => x.Blogid == id).Include(x => x.ReplyClasses).ToList();
            return View(bc);
        }

        [HttpPost]
        public ActionResult Create(Comment cm, int? blogid)
        {

            if (Session["Kullanici"] !=null)
            {
                cm.IsAdmin = true;
                
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Message = "dfadadwda";
                return View("Blogdetail/blogid", cm);

            }
                if (blogid == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                Blog b = c.Blogs.Find(blogid);

                if (b == null)
                {
                    return new HttpNotFoundResult();
                }
                if (string.IsNullOrEmpty(cm.KullanıcıADI))
                {
                    cm.KullanıcıADI = "Anonim";
                }

                cm.Blog = b;
                cm.CreatedAt = DateTime.Now;
                c.Comments.Add(cm);
                int result = c.SaveChanges();
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Reply(ReplyClass rp, int? YorumID)
        {
            if (ModelState.IsValid)
            {
                Comment cm = c.Comments.Find(YorumID);
                rp.Yorum = cm;
                rp.CreatedAt = DateTime.Now;
                c.ReplyClasses.Add(rp);
                c.SaveChanges();
            }
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }
    }
}