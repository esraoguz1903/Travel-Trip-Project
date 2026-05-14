using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Home
    {
        [Key] //Bu sınıfın Id property'si birincil anahtar olduğunu belirtir.
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}