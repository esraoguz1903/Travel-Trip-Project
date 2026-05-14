using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Classes
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; } //Bir ülkenin birden fazla destinasyonu olabilir, bu yüzden ICollection kullanıyoruz
    }
}