using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes; // Modelleri kullanabilmek için ekledik

namespace Travel_Trip_Project.Controllers
{
    public class AdminController : Controller
    {
        // Veritabanı bağlantımızı global olarak tanımlıyoruz
        Context c = new Context();

        // ================= 1. DASHBOARD =================
        [HttpGet]
        [Authorize]
        public ActionResult AdminHome()
        {
            ViewBag.BlogCount = c.Blogs.Count();
            ViewBag.DestinationCount = c.Destinations.Count();
            ViewBag.ContactCount = c.Contacts.Count();
            return View();
        }

        // ================= 2. BLOG YÖNETİMİ =================
        [HttpGet]
        public ActionResult BlogList()
        {
            var blogs = c.Blogs.ToList();
            return View(blogs);
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        [HttpGet]
        public ActionResult GetBlog(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("GetBlog", blog); // GetBlog View'ını geri döndürür, model ile birlikte
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog b)
        {
            var blog = c.Blogs.Find(b.Id);
            blog.Title = b.Title;
            blog.BlogDate = b.BlogDate;
            blog.Description = b.Description;
            blog.BlogImage = b.BlogImage;
            
            c.SaveChanges();
            return RedirectToAction("BlogList");
        }

        // ================= 3. REHBER / DESTİNASYON YÖNETİMİ =================
        [HttpGet]
        public ActionResult DestinationList()
        {
            var destinations = c.Destinations.ToList();
            return View(destinations);
        }

        [HttpGet]
        public ActionResult AddDestination()
        {
            List<SelectListItem> countries = (from x in c.Countries.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.Id.ToString()
                                              }).ToList();
            ViewBag.Countries = countries;
            return View();
        }

        [HttpPost]
        public ActionResult AddDestination(Destination d)
        {
            c.Destinations.Add(d);
            c.SaveChanges();
            return RedirectToAction("DestinationList");
        }

        public ActionResult DeleteDestination(int id)
        {
            var destination = c.Destinations.Find(id);
            c.Destinations.Remove(destination);
            c.SaveChanges();
            return RedirectToAction("DestinationList");
        }

        [HttpGet]
        public ActionResult GetDestination(int id)
        {
            List<SelectListItem> countries = (from x in c.Countries.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.Id.ToString()
                                              }).ToList();
            ViewBag.Countries = countries;
            var destination = c.Destinations.Find(id);
            return View("GetDestination", destination);
        }

        [HttpPost]
        public ActionResult UpdateDestination(Destination d)
        {
            var destination = c.Destinations.Find(d.Id);
            destination.CountryId = d.CountryId;
            destination.Place = d.Place;
            destination.Cafe = d.Cafe;
            destination.PlaceImage = d.PlaceImage;
            destination.Description = d.Description;
            destination.IsTop10 = d.IsTop10;
            destination.IsBestPlace = d.IsBestPlace;
            
            c.SaveChanges();
            return RedirectToAction("DestinationList");
        }

        // ================= 4. İLETİŞİM MESAJLARI =================
        [HttpGet]
        public ActionResult ContactList()
        {
            var messages = c.Contacts.ToList();
            return View(messages);
        }

        public ActionResult DeleteContact(int id)
        {
            var message = c.Contacts.Find(id);
            c.Contacts.Remove(message);
            c.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public ActionResult MessageDetails(int id)
        {
            // İletişim formundan gelen uzun bir mesajı tek ekranda okumak için
            var message = c.Contacts.Find(id);
            return View("MessageDetails", message);
        }

        // ================= 5. HAKKIMIZDA (ABOUT) YÖNETİMİ =================
        [HttpGet]
        public ActionResult AboutList()
        {
            var abouts = c.Abouts.ToList();
            return View(abouts);
        }

        [HttpGet]
        public ActionResult GetAbout(int id)
        {
            var about = c.Abouts.Find(id);
            return View("GetAbout", about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About a)
        {
            var about = c.Abouts.Find(a.Id);
            about.Title = a.Title;
            about.PhotoUrl = a.PhotoUrl;
            about.Description = a.Description;
            
            c.SaveChanges();
            return RedirectToAction("AboutList");
        }

        // ================= 6. ANA SAYFA (HOME) YÖNETİMİ =================
        [HttpGet]
        public ActionResult HomeList()
        {
            var homeInfo = c.Homes.ToList();
            return View(homeInfo);
        }

        [HttpGet]
        public ActionResult GetHome(int id)
        {
            var home = c.Homes.Find(id);
            return View("GetHome", home);
        }

        [HttpPost]
        public ActionResult UpdateHome(Home h)
        {
            var home = c.Homes.Find(h.Id);
            home.Title = h.Title;
            home.Description = h.Description;
            
            c.SaveChanges();
            return RedirectToAction("HomeList");
        }
    }
}