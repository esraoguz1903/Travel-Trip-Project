using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StreetAddress { get; set; }  //Açık adres
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}