using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Comments
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; } //Yorumun hangi bloga ait olduğunu göstermek için BlogId adında bir property oluşturuyoruz
        public virtual Blog Blog { get; set; } //Yorumun hangi bloga ait olduğunu göstermek için Blog sınıfına sanal bir property oluşturuyoruz 
        //Bu sayede Entity Framework, Comments sınıfı ile Blog sınıfı arasında bir ilişki kurabilir ve yorumların hangi bloga ait olduğunu belirleyebilir. //


    }
}