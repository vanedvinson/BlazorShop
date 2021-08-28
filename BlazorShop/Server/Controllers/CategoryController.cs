using BlazorShop.Shared.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(new List<Category>
                {
                    new Category {ID=1, Name="Category 1", URL="category1", Icon="book"},
                    new Category {ID=2, Name="Category 2", URL="category2", Icon="fire"},
                    new Category {ID=3, Name="Category 3", URL="category3", Icon="check"},
                });
        }
    }
}
