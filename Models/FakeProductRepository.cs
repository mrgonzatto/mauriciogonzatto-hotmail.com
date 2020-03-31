using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProgWeb202.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product{ Name = "Bola de Futebol", Price = 25 },
            new Product{ Name = "Bola de Ping-Pong", Price = 5 }
        }.AsQueryable<Product>();
    }
}
