
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VmcLesson09.Modelsss;

namespace Vmcleson11.Controllers
{
    public class VmcCategoriesController : Controller
    {
        private readonly VmcBookStoreContext _context;

        public VmcCategoriesController(VmcBookStoreContext context)
        {
            _context = context;
        }

        // GET: VmcCategories
        public async Task<IActionResult> VmcIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: VmcCategories/VmcDetails/5
        public async Task<IActionResult> VmcDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        // GET: VmcCategories/VmcCreate
        public IActionResult VmcCreate()
        {
            return View();
        }

        // POST: VmcCategories/VmcCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VmcCreate([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(VmcIndex));
            }
            return View(category);
        }

        // GET: VmcCategories/VmcEdit/5
        public async Task<IActionResult> VmcEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        // POST: VmcCategories/VmcEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VmcEdit(int id, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (id != category.CategoryId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(VmcIndex));
            }
            return View(category);
        }
        // GET: Categories/Delete/5
        public async Task<IActionResult> VmcDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("VmcDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VmcDeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(VmcIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
