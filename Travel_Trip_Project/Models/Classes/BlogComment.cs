using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> BlogList { get; set; } 
        //Blog sınıfından bir IEnumerable türünde Blogs adında bir property oluşturuyoruz. Bu property, blogların listesini tutmak için kullanılacak.
        public IEnumerable<Comments> CommentList { get; set; } 
        //Comments sınıfından bir IEnumerable türünde Comments adında bir property oluşturuyoruz. Bu property, yorumların listesini tutmak için kullanılacak.
    }
}