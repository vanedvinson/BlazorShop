using BlazorShop.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task LoadProducts(string CategoryUrl = null);
    }
}
