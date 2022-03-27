using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Office_Website.Models.Class;
using System.Web;

namespace Office_Website.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        //HOMEPAGE
        public ActionResult Index()
        {
            Admin ad = Session["Kullanici"] as Admin;
            var user = c.Admins.Find(ad.Id);
                if (user.IsManager)
                {
                    var values = c.Blogs.ToList();
                    return View(values);
                }
                else
                {
                    var values = c.Blogs.Where(x => x.AdminId == ad.Id).ToList();
                    return View(values);
                }
        }

        //BLOG OPERATIONS
        [HttpGet]
        public ActionResult NewBlog(int id)
        {


            List<SelectListItem> value = (from i in c.Topic.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KonuAD,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.vl = value;
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {

            var bl = c.Topic.Where(m => m.Id == b.Konu.Id).FirstOrDefault();
            b.Konu = bl;
            b.CreatedAt = DateTime.Now;
            b.UpdadedAt = DateTime.Now;
            c.Blogs.Add(b);
            int id = b.AdminId;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult deleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            int adid = b.AdminId;
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var get = c.Blogs.Find(id);
            List<SelectListItem> value = (from i in c.Topic.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KonuAD,
                                              Value = i.Id.ToString()
                                          }).ToList();
            ViewBag.vl = value;
            return View("GetBlog", get);
        }
        public ActionResult updateBlog(Blog b)
        {
            var upd = c.Blogs.Find(b.Id);
            upd.UpdadedAt = DateTime.Now; ;
            upd.aciklama = b.aciklama;
            upd.Baslik = b.Baslik;
            
            var bl = c.Topic.Where(m => m.Id == b.Konu.Id).FirstOrDefault();
            upd.BlogResmi = b.BlogResmi;
            upd.KonuId = bl.Id;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        ///////////////////////////////////////////////////////

        //TOPİC OPERATIONS
        public ActionResult listTopic()
        {
            var values = c.Topic.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewTopic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewTopic(Topic t)
        {
            t.CreatedAt = DateTime.Now;
            c.Topic.Add(t);
            c.SaveChanges();
            return RedirectToAction("listTopic");
        }

        public ActionResult deleteTopic(int id)
        {
            var b = c.Topic.Find(id);
            c.Topic.Remove(b);
            c.SaveChanges();
            return RedirectToAction("listTopic");
        }


        public ActionResult GetTopic(int id)
        {
            var get = c.Topic.Find(id);
            return View(get);
        }

        public ActionResult UpdateTopic(Topic t)
        {
            var newt = c.Topic.Find(t.Id);
            newt.CreatedAt = DateTime.Now;
            newt.KonuAciklama = t.KonuAciklama;
            newt.KonuResim = t.KonuResim;
            newt.KonuAD = t.KonuAD;
            c.SaveChanges();
            return RedirectToAction("listTopic");
        }
        ///////////////////////////////////////////////////////

        //CONTACT OPERATIONS
        public ActionResult GetContact(int id)
        {
            var get = c.Addresses.Find(id);
            return View(get);
        }
        public ActionResult ListContact()
        {
            var get = c.Addresses.ToList();
            return View(get);
        }
        public ActionResult updateContact(Address ad)
        {
            var newads = c.Addresses.Find(ad.Id);
            newads.CreatedAt = DateTime.Now;
            newads.Başlık = ad.Başlık;
            newads.AcıkAdress = ad.AcıkAdress;
            newads.konum = ad.konum;
            newads.telefon = ad.telefon;
            newads.mail = ad.mail;
            newads.openhours = ad.openhours;
            c.SaveChanges();
            return RedirectToAction("ListContact");
        }
        ///////////////////////////////////////////////////////


        //COMMENT OPERATIONS
        public ActionResult GetComment()
        {
            var get = c.Comments.ToList();
            return View(get);
        }
        public ActionResult deleteComment(int id)
        {
            var y = c.Comments.Find(id);
            c.Comments.Remove(y);
            c.SaveChanges();
            return RedirectToAction("GetComment");
        }

        ///////////////////////////////////////////////////////
        public ActionResult ListAbout()
        {
            var get = c.Abouts.ToList();
            return View(get);
        }
        public ActionResult GetAbout(int id)
        {
            var get = c.Abouts.Find(id);
            return View(get);
        }

        public ActionResult UpdateAbout(About a)
        {
            var newAbout = c.Abouts.Find(a.Id);
            newAbout.CreatedAt = DateTime.Now;
            newAbout.aciklama = a.aciklama;
            newAbout.aciklama2 = a.aciklama2;
            newAbout.FotoUrl = a.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("ListAbout");
        }
        ///////////////////////////////////////////////////////

        //ADMIN OPERATIONS
        public ActionResult ListAdmin()
        {
            var ad = c.Admins.ToList();
            return View(ad);
        }

        [HttpGet]
        public ActionResult NewAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewAdmin(Admin ad)
        {
            return View();
        }
        ///////////////////////////////////////////////////////

    }
}