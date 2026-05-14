using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //Entity Framework kullanarak veritabanı işlemlerini yapacağız

namespace Travel_Trip_Project.Models.Classes
{
    //Veritabanı işlemlerini yapacağımız sınıf
    //Tabloları temsil eden sınıflarımızı burada tanımlayacağız
    //Tabloları temsil eden sınıflarımızı tanımladıktan sonra, bu sınıfları kullanarak veritabanı işlemlerini yapacağız
    //Tabloları veritabanında oluşturmak için bu sınıfın DbContext sınıfından türemesi gerekiyor.
    //Tabloları veritabanında oluşturmak için, Package Manager Console'da "Add-Migration InitialCreate" komutunu kullanarak bir migration oluşturacağız
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Home> Homes { get; set; }

    }
}