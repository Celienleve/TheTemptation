using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheTemptation.Models;
using TheTemptation.Services;

namespace TheTemptation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TheTemptationDBContext dBContext;
        private readonly IHomeService _homeService;


        public HomeController(ILogger<HomeController> logger, TheTemptationDBContext dBContext, IHomeService homeService)
        {
            _logger = logger;
            this.dBContext = dBContext;
            _homeService= homeService;
        }

        public IActionResult Index()
        {

            var resultat = new IndexViewModel
            {
                GameWin = _homeService.AffichageJeu()
            };

            return View(resultat);
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