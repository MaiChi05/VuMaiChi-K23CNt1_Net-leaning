using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vmcDay07.Models;

namespace vmcDay07.Controllers
{
    public class VmcHomeController : Controller
    {
        private readonly ILogger<VmcHomeController> _logger;

        public VmcHomeController(ILogger<VmcHomeController> logger)
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
        public IActionResult vmcAbout()
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
