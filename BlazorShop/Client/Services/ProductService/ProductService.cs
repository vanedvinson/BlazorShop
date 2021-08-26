using BlazorShop.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    ID=1,
                    CategoryID=1,
                    Title="The Hitchhiker's Guide to the Galaxy",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=2,
                    CategoryID=3,
                    Title="The Hitchhiker's Guide to the Galaxy 2",
                    Descripton="Some description 2",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=19.99m,
                    OriginalPrice=29.99m
                },
                new Product
                {
                    ID=3,
                    CategoryID=1,
                    Title="The Hitchhiker's Guide to the Galaxy",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=4,
                    CategoryID=1,
                    Title="The Hitchhiker's Guide to the Galaxy",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=5,
                    CategoryID=1,
                    Title="The Hitchhiker's Guide to the Galaxy",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                },
                new Product
                {
                    ID=6,
                    CategoryID=1,
                    Title="The Hitchhiker's Guide to the Galaxy",
                    Descripton="Some description",
                    ImageLink="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price=9.99m,
                    OriginalPrice=19.99m
                }
            };
        }
    }
}
