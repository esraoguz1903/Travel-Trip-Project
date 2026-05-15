using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        Context c = new Context();
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.User, false);
                Session["User"] = bilgiler.User.ToString();
                return RedirectToAction("AdminHome", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "AdminLogin");
        }
    }
}