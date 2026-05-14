namespace Travel_Trip_Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Travel_Trip_Project.Models.Classes.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //Bu özellik, veritabanı şemasında yapılan değişiklikleri otomatik olarak algılar ve veritabanını günceller.
                                               //Ancak, bu özellik bazı durumlarda veri kaybına neden olabilir, bu yüzden dikkatli kullanılması gerekir.
        }

        protected override void Seed(Travel_Trip_Project.Models.Classes.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
