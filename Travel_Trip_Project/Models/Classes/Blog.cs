using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime BlogDate { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }

        public ICollection<Comments> Comments { get; set; } //Bir blogun birden fazla yorumu olabilir, bu yüzden ICollection kullanıyoruz

    }
}