using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class CommentController : Controller
    {
        Context c = new Context();

        // ================= YORUM YÖNETİMİ =================

        // Tüm yorumları listele
        [HttpGet]
        public ActionResult CommentList()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }

        // Belirli bir blogun yorumlarını listele
        [HttpGet]
        public ActionResult CommentsByBlog(int blogId)
        {
            var comments = c.Comments.Where(x => x.BlogId == blogId).ToList();
            ViewBag.Blog = c.Blogs.Find(blogId);
            return View("CommentList", comments);
        }

        // Yorum detayını göster
        [HttpGet]
        public ActionResult CommentDetails(int id)
        {
            var comment = c.Comments.Find(id);
            return View("CommentDetails", comment);
        }

        // Yorumu sil
        public ActionResult DeleteComment(int id)
        {
            var comment = c.Comments.Find(id);
            c.Comments.Remove(comment);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}
