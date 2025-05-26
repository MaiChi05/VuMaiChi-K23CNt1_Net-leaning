using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vmcDay06.Models;

namespace vmcDay06.Controllers
{
    public class vmcHomeController : Controller
    {
        private readonly ILogger<vmcHomeController> _logger;

        public vmcHomeController(ILogger<vmcHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult vmcIndex()
        {
            return View();
        }

        public IActionResult vmcPrivacy()
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
