using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Home()
        {
            var resimler = c.Blogs.ToList();
            return View(resimler);
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Destinations.Distinct().ToList();
            return PartialView(degerler);
        }
    }
}