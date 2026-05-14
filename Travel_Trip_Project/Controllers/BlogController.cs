using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Classes;

namespace Travel_Trip_Project.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult MyBlog()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        BlogComment blogComment = new BlogComment();
        public ActionResult BlogList()
        {
            //var degerler = c.Blogs.ToList();
            blogComment.BlogList = c.Blogs.ToList();
            blogComment.CommentList = c.Comments.ToList();
            return View(blogComment);
        }
        
        public ActionResult BlogDetails(int id)
        {
            //var degerler = c.Blogs.Where(x => x.Id == id).ToList();
            blogComment.BlogList = c.Blogs.Where(x => x.Id == id).ToList();
            blogComment.CommentList = c.Comments.Where(x=> x.BlogId == id).ToList();
            return View(blogComment);
        }
        public ActionResult AddComment(Comments comments)
        {
            c.Comments.Add(comments);
            c.SaveChanges();
            return RedirectToAction("BlogDetails");
        }

    }
}