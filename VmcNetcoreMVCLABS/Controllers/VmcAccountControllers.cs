using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VmcNetcoreMVCLABS.Models;

namespace VmcNetcoreMVCLABS.Controllers
{
    public class VmcAccountControllers : Controller
    {
        // GET: VmcAccountControllers
        public ActionResult Index()
        {
            List<VmcAccount> accounts = new List<VmcAccount>();
            return View(accounts);
        }

        // GET: VmcAccountControllers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VmcAccountControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VmcAccountControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VmcAccountControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VmcAccountControllers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VmcAccountControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VmcAccountControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
