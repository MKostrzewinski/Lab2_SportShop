using Lab2_SportShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_SportShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product{ Name = "Piłka Nożna",Price =25},
            new Product{ Name = "Deska Surfingowa",Price =179},
            new Product{ Name = "Buty do biegania",Price =55}

    }.AsQueryable<Product>();
    }
}