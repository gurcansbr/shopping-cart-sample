using ShoppingCartSample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShoppingCartSample.Client.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Product[]> GetProducts()
        {
            return await _http.GetFromJsonAsync<Product[]>("api/product/list");
        }
    }
}
