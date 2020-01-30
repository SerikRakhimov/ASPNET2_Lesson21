namespace IdentityApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentityApplication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IdentityApplication.Models.ApplicationDbContext context)
        {
            //context.Positions.AddRange(new List<Position>{
            //    new Position
            //    {
            //        Id = 1,
            //        Name = "Админ"
            //    },
            //    new Position
            //    {
            //        Id = 2,
            //        Name = "Пользователь"
            //    }
            //});
            //context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
