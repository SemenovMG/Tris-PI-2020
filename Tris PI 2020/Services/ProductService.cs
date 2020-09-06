using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tris_PI_2020.Entities;

namespace Tris_PI_2020.Services
{
    public class ProductService
    {
        private readonly List<Product> products;

        public ProductService()
        {
            products = new List<Product>
            {
                new Product{Id = 1, Name = "Клавиатура", Price = 10M},
                new Product{Id = 2, Name = "Мышь", Price = 20M},
                new Product{Id = 3, Name = "Моник", Price = 205M},
                new Product{Id = 4, Name = "Лампа", Price = 15M},
                new Product{Id = 5, Name = "Кружка", Price = 5M}
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }

}
