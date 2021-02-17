using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcFoundamentals.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class ProductCollection
    {
        public List<Product> products { get; set; }
        public ProductCollection()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductId = 1,
                Name = "Шариковая ручка",
                Description = "Синяя шариковая ручка с колпачком и прозрачным корпусом.",
                Price = 3m,
                Category = "Канцтовары"
            });

            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Бумага A4",
                Description = "Стандартная бумага для цветной и чёрно-белой печати.",
                Price = 15m,
                Category = "Канцтовары"
            });

            products.Add(new Product()
            {
                ProductId = 2,
                Name = "Мобильный телефон",
                Description = "Мобильный телефон с фотокамерой.",
                Price = 250m,
                Category = "Техника"
            });
        }
    }
}