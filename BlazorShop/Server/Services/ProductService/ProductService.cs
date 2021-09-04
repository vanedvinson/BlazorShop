using BlazorShop.Server.Data;
using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Shared.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetProduct(int ID)
        {
            Product product = await _context.Products
                .Include(p=> p.Editions).FirstOrDefaultAsync(p => p.ID == ID);
            return product;
        }
        public async Task<List<Product>> GetProductsByCategory(string CategoryURL)
        {
            Category category = await _categoryService.GetCategoryByUrl(CategoryURL);
            return await _context.Products.Where(p => p.CategoryID == category.ID).ToListAsync();
        }


        /*public List<Product> Products { get; set; } = new List<Product>
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
        };*/


    }
}
