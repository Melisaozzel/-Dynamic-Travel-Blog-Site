using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;
namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Remove(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("GetBlog", blog);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Content = b.Content;
            blg.Title = b.Title;
            blg.Date = b.Date;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comment = c.Commentss.ToList();
            return View(comment);
        }
        public ActionResult RemoveComment(int id)
        {
            var b = c.Commentss.Find(id);
            c.Commentss.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult GetComment(int id)
        {
            var yr = c.Commentss.Find(id);
            return View("GetComment", yr);
        }

        public ActionResult UpdateComment(Comments y)
        {
            var yrm= c.Commentss.Find(y.ID);
            yrm.UserName = y.UserName;
            yrm.Mail = y.Mail;
            yrm.Comment = y.Comment;
            
            c.SaveChanges();
            return RedirectToAction("CommentList");
             
        }
    }
}
