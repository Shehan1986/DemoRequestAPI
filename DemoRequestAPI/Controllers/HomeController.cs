using DemoRequestAPI.Models;
using DemoRequestAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoRequestAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _productService = productService;
            _logger = logger;
        }

        public IActionResult Index()
        {

            //int number = 5;
            //var stringNumber = number.ToString();
            
            return View();
        }

        public IActionResult GetProduct()
        {

            int number = 5;
            var stringNumber = number.ToString();

            return View(_productService.GetProducts(stringNumber));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
