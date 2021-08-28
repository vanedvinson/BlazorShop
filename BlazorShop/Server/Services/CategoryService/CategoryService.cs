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
                new Category {ID=1, Name="Feder Klompe", URL="feder", Icon="book"},
                new Category {ID=2, Name="Vazdusne Klompe", URL="vazdusne-klompe", Icon="fire"},
                new Category {ID=3, Name="Poliuretanske Klompe", URL="pu-klompe", Icon="check"},
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
