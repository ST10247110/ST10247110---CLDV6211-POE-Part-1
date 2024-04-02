using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ST10247110___CLDV6211_POE_Part_1.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace ST10247110___CLDV6211_POE_Part_1.Controllers
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
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }

        private List<ArtPiece> GetArtPieces()
        {
            var artPieces = new List<ArtPiece>
    {
        new ArtPiece { artID = 1, artTitle = "Large Traditional Basket With Lid", artDescription = "This is a traditional large hand woven basket with a lid, beautiful and practical.", artPrice = 400.00m, artImageURL = "~/images/productimage1.jpg" },
        new ArtPiece { artID = 2, artTitle = "Genuine Ebony Wooden Carving (Man)", artDescription = "Made out of Ebony wood, this hand carved wooden sculpture is a proud statement of beauty and skilled craftsmanship.", artPrice = 650.00m, artImageURL = "~/images/productimage2.jpg" },
        new ArtPiece { artID = 3, artTitle = "African Villiage Women Life", artDescription = "Painted by Jafeth Moaine, this is an Acrylic on Canvas Piece.", artPrice = 14896.00m, artImageURL = "~/images/productimage3.jpg" }
    };

            return artPieces;
        }
        public IActionResult MyWork()
        {
            var artPieces = GetArtPieces();
            return View(artPieces);
        }

        public IActionResult Contact()
        {
            return View();
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
