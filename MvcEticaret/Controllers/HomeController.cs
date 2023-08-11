using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductItemViewModel>
        {
            new ProductItemViewModel { Title = "Tommy Hilfiger Blue Dress", StartCount = 4, OldPrice = 120.90, Price = 90, ImageUrl = "../images/tommy-hilfiger-gathered-waist-drape-short-dress.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Red Dress", StartCount = 5, OldPrice = 110.0, Price = 55.0, ImageUrl = "../images/istockphoto-184354439-612x612.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Purple Dress", StartCount = 5, OldPrice = 250, Price = 100, ImageUrl = "../images/360_F_163577358_6wSWA9Sc6CDeRwA6uWNSPKYu37LTzRsw.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Green Dress", StartCount = 4, OldPrice = 399.90, Price =300 , ImageUrl = "../images/istockphoto-492462644-612x612.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Bridal Gown", StartCount = 3, OldPrice = 99.90, Price =59.90 , ImageUrl = "../images/images.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Gray Dress", StartCount = 5, OldPrice = 222, Price = 111, ImageUrl = "../images/00469460-05.jpg", IsSale = true },
            new ProductItemViewModel { Title = "Red Dress on Model", StartCount = 4, OldPrice = 199.90, Price =119.90 , ImageUrl = "../images/2084_kirmizi_-1-300x450.jpg", IsSale = false },
            new ProductItemViewModel { Title = "Blue dress", StartCount = 4, OldPrice = 250.0, Price = 119.90, ImageUrl = "../images/images (1).jpg", IsSale = true },
        };

            return View(products);
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