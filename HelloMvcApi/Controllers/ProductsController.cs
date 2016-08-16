using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/products")]
    public class ProductsController
    {
        private static List<Product> _products = 
            new List<Product>(new[] {
            new Product() { Id = 1, Name = "Cooler" },
            new Product() { Id = 2, Name = "Radio" },
            new Product() { Id = 3, Name = "Bicycle" },
            new Product() { Id = 4, Name = "Kayak" },
            new Product() { Id = 5, Name = "Surfboard" },
            new Product() { Id = 6, Name = "Blanket" },
            new Product() { Id = 7, Name = "Suntan lotion" },
            new Product() { Id = 8, Name = "Beach chair" },
            new Product() { Id = 9, Name = "Umbrella" },
            new Product() { Id = 10, Name = "Sunglasses" },
            new Product() { Id = 11, Name = "Camera" },
            new Product() { Id = 12, Name = "Binoculars" },
        });

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}