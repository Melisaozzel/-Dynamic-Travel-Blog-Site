using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;
namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Abts.ToList();
            return View(degerler);
        }
    }
}