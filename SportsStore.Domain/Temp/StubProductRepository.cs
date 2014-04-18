using SportsStore.Domain.Abstract;
using SportsStore.Domain.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Temp
{
    public class StubProductRepository : IProductRepository
    {
        public IQueryable<Product> Products { get; private set; }
        
        public StubProductRepository()
        {
            Products = new List<Product> 
            {
                new Product { Name = "Football", Price = 25},
                new Product { Name = "Surf Board", Price = 179},
                new Product { Name = "Running Shoes", Price = 95}
            }.AsQueryable();
        }
    }
}
