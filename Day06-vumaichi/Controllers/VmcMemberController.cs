using Day06_vumaichi.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Day06_vumaichi.Controllers
{
    public class VmcMemberController : Controller
    {
        // Static list to simulate database
        public static readonly List<VmcMember> VmcMembers = new List<VmcMember>()
        {
            new VmcMember { VmcMemberId = Guid.NewGuid().ToString(), VmcUserName = "Hiến", VmcFullName = "Nguyễn Ngọc Hiến", VmcPassword = "1234", VmcEmail = "ngochien@gmail.com" },
            new VmcMember { VmcMemberId = Guid.NewGuid().ToString(), VmcUserName = "Anh", VmcFullName = "Trần Tiến Anh", VmcPassword = "123456", VmcEmail = "tv2@gmail.com" },
            new VmcMember { VmcMemberId = Guid.NewGuid().ToString(), VmcUserName = "An", VmcFullName = "Vũ Minh An", VmcPassword = "123456", VmcEmail = "tv3@gmail.com" },
            new VmcMember { VmcMemberId = Guid.NewGuid().ToString(), VmcUserName = "Bình", VmcFullName = "Trịnh Văn Bình", VmcPassword = "123456", VmcEmail = "tv4@gmail.com" },
            new VmcMember { VmcMemberId = Guid.NewGuid().ToString(), VmcUserName = "Minh", VmcFullName = "Lê Tiến Minh", VmcPassword = "123456", VmcEmail = "tv5@gmail.com" },
        };

        // Index page
        public IActionResult VmcIndex()
        {
            return View();
        }

        // Return a hardcoded single member
        public IActionResult VmcGetMember()
        {
            var vmcMember = new VmcMember
            {
                VmcMemberId = Guid.NewGuid().ToString(),
                VmcUserName = "Mai Chi",
                VmcFullName = "Vũ Mai Chi",
                VmcPassword = "1234",
                VmcEmail = "Maichi@gmail.com"
            };

            ViewBag.VmcMember = vmcMember;
            return View();
        }

        // Return list of all members
        public IActionResult VmcGetMembers()
        {
            ViewBag.VmcMembers = VmcMembers;
            return View();
        }

        // Display the form to create a new member
        [HttpGet]
        public IActionResult CreateMember()
        {
            return View();
        }

        // Handle form submission for creating new member
        [HttpPost]
        public IActionResult CreateMember(VmcMember member)
        {
            if (ModelState.IsValid)
            {
                member.VmcMemberId = Guid.NewGuid().ToString();
                VmcMembers.Add(member);
                return RedirectToAction(nameof(VmcGetMembers));
            }

            return View(member);
        }
    }
}
