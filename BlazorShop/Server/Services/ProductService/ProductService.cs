using BlazorShop.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }
        public async Task<Product> GetProduct(int ID)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Product>> GetProductsByCategory(string CategoryURL)
        {
            throw new NotImplementedException();
        }
        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
                {
                    ID=1,
                    CategoryID=1,
                    Title="Proizvod 1 - kat1",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=2,
                    CategoryID=3,
                    Title="Proizvod 2 - kat3",
                    Descripton="Some description 2",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=19.99m,
                    OriginalPrice=29.99m
                },
                new Product
                {
                    ID=3,
                    CategoryID=1,
                    Title="Proizvod 3 - kat1",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=4,
                    CategoryID=1,
                    Title="Proizvod 4 - kat1",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=5,
                    CategoryID=3,
                    Title="Proizvod 5 - kat3",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=6,
                    CategoryID=2,
                    Title="Proizvod 6 - kat2",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                }
            };


    }
}
