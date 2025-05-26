using System.Diagnostics;
using Day06_vumaichi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day06_vumaichi.Controllers
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
