using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        [HttpGet]
        public ActionResult ContactPages()
        {
            return View();
        }
       

        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            c.Contacts.Add(p);
            c.SaveChanges();
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";  // View tarafında popup gösterebilmek için TempData ile bir mesaj yolluyoruz
            return RedirectToAction("ContactPages");
        }
    }
}