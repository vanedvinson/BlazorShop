using BlazorShop.Shared.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string CategoryUrl = null)
        { 
            if(CategoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{CategoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int ID)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{ID}");
        }


    }
}
