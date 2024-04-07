using Microsoft.AspNetCore.Mvc;
using SunElectricalServices.Models;
using System.Diagnostics;

namespace SunElectricalServices.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Residential()
        {
            return View();
        }

        public IActionResult Commercial()
        {
            return View();
        }

        public IActionResult EVChargers()
        {
            return View();
        }

        public IActionResult SwitchBoardUpgrades()
        {
            return View();
        }

        public IActionResult SmartHomeInstallations()
        {
            return View();
        }

        public IActionResult MaintainaceandServicing()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
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
