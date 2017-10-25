using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/products")]
    public class ProductsController
    {
        private static List<Product> _products = 
            new List<Product>(new[] {
            new Product() { Id = 1, Name = "Computer" },
            new Product() { Id = 2, Name = "Tablet" },
            new Product() { Id = 3, Name = "Notebook" },
        });

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}