using DemoRequestAPI.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DemoRequestAPI.Services
{
    public class ProductService: IProductService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public ProductService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        { 
            _configuration = configuration;
            _httpClient = httpClientFactory.CreateClient("productrequest");   
        }

        public List<Product> GetProducts(string noOfProducts="5")
        {
            var productlistJson = _httpClient.GetStringAsync($"?number={noOfProducts}").Result;
            var prductlistCsharp = JsonConvert.DeserializeObject<List<Product>>(productlistJson)!;
            return prductlistCsharp;
        }
    }
}
