using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Destination
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } //Destination sınıfı ile Country sınıfı arasında bir ilişki kurmak için Country sınıfına sanal bir property oluşturuyoruz
        public string Cafe { get; set; }
        public string PlaceImage { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public bool IsTop10 { get; set; }
        public bool IsBestPlace { get; set; }
    }
}