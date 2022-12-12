using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheTemptation.Models;

namespace TheTemptation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TheTemptationDBContext dBContext;

        public HomeController(ILogger<HomeController> logger, TheTemptationDBContext dBContext)
        {
            _logger = logger;
            this.dBContext = dBContext;
        }

        public IActionResult Index()
        {
            return View(dBContext.Draws) ;
        }

        public IActionResult Jeu()
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