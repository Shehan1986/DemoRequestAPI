using DemoRequestAPI.Models;

namespace DemoRequestAPI.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts(string noOfProducts);
    }
}
