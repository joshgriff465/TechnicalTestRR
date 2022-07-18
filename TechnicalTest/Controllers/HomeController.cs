using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TechnicalTest.Models;
using TechnicalTest.SQL;

namespace TechnicalTest.Controllers
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
            HomeModel model = new HomeModel();
            model.drinkList = DataSQL.GetDrinks();
            return View(model);
        }
        [HttpPost]
        public IActionResult Instructions(int drinkId)
        {
            HomeModel model = new HomeModel();
            model.instructionList = DataSQL.GetInstructions(drinkId);
            ViewBag.DrinkTitle = DataSQL.GetDrinkNameById(drinkId);

            return View("~/Views/Shared/_Instructions.cshtml", model);
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