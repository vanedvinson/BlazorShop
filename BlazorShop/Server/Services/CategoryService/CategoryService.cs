using BlazorShop.Server.Data;
using BlazorShop.Shared.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        /*public List<Category> Categories { get; set; } = new List<Category>
        {
            new Category {ID=1, Name="Category 1", URL="category1", Icon="book"},
            new Category {ID=2, Name="Category 2", URL="category2", Icon="fire"},
            new Category {ID=3, Name="Category 3", URL="category3", Icon="check"},
        };*/ 

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string CategoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.URL.ToLower().Equals(CategoryUrl.ToLower()));  
        }
    }
}
