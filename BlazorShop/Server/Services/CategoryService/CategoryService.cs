using BlazorShop.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category {ID=1, Name="Category 1", URL="category1", Icon="book"},
                new Category {ID=2, Name="Category 2", URL="category2", Icon="fire"},
                new Category {ID=3, Name="Category 3", URL="category3", Icon="check"},
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
     }
}
