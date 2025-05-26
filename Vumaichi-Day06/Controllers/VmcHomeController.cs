using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vumaichi_Day06.Models;

namespace Vumaichi_Day06.Controllers
{
    public class VmcHomeController : Controller
    {
        private readonly ILogger<VmcHomeController> _logger;

        public VmcHomeController(ILogger<VmcHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VmcIndex()
        {
            return View();
        }
        public IActionResult VmcAbout()
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
