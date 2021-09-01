using BlazorShop.Server.Services.ProductService;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }
        [HttpGet("{CategoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string CategoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(CategoryUrl));
        }
    }
}
 