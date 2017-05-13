using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class ProductInMemoryRepository : IProductRepository
    {
        public IEnumerable<ProductGridViewModel> Getproducts()
        {
            return new[]
            {
                new ProductGridViewModel
                {
                    Id = 1,
                    Name = "Product pierwszy",
                    Price = 10
                },

                new ProductGridViewModel
                {
                    Id = 2,
                    Name = "Product drugi",
                    Price = 20
                },

                new ProductGridViewModel
                {
                    Id = 3,
                    Name = "Product Trzeci",
                    Price = 30
                },
            };

        }

        public ProductDetailsViewModel Get(long id)
        {
            return new ProductDetailsViewModel
            {
                Id = 1,
                Name = "Nowy",
                Price = 250
            };
        }

    }
}