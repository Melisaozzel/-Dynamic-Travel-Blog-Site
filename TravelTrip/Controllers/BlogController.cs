using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;
namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogComment by = new BlogComment();

        public ActionResult Index()
        {

            // var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(by);
        }


        public ActionResult BlogDetay(int id)
        {
            // var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Commentss.Where(x => x.BLOGID == id).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return View(by);
        }
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        
        [HttpPost]
    public PartialViewResult AddComment(Comments y)
        {
            c.Commentss.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}