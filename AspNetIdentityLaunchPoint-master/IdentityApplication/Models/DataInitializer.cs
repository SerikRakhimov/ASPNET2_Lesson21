using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityApplication.Models
{
    public class DataInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
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
        }
    }
}