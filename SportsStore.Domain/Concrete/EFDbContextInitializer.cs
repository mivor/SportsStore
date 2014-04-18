using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SportsStore.Domain.Enitites;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContextInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            context.Products.AddRange(new[]
            {
                new Product { Name = "Kayak", Description="A boat", Category="Watersports", Price = 25.5M},
                new Product { Name = "Lifejacket", Description="A boat", Category="Watersports", Price = 26.5M},
                new Product { Name = "Ball", Description="A boat", Category="Soccer", Price = 65.5M},
                new Product { Name = "Flag", Description="A boat", Category="Soccer", Price = 85.5M},
                new Product { Name = "Shoes", Description="A boat", Category="Soccer", Price = 251.5M},
                new Product { Name = "Chair", Description="A boat", Category="Chess", Price = 5.5M},
                new Product { Name = "Timer", Description="A boat", Category="Chess", Price = 254.5M},
                new Product { Name = "Figure", Description="A boat", Category="Chess", Price = 95.5M},
            });

            context.SaveChanges();
        }
    }
}
