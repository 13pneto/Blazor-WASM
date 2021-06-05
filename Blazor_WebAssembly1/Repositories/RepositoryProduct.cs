using Blazor_WebAssembly1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor_WebAssembly1.Repositories
{
    public class RepositoryProduct : IRepositoryProduct
    {
        private readonly HttpClient _http;
        public RepositoryProduct(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _http.GetFromJsonAsync<List<Product>>("dados/products.json");
        }
    }
}
