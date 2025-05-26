using Microsoft.AspNetCore.Mvc;

namespace lesson05_Vumaichi.Controllers
{
    public class VmcMemberHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VmcGetMember()
        {

          var vmcMember = new VmcMember();
            vmcMember.VmcMemberId = Guid.NewGuid().ToString();
            vmcMember.VmcUserName = "Mai Chi";
            vmcMember.VmcFullName = "Vũ Mai Chi";
            vmcMember.VmcPassword = "1234";
            vmcMember.VmcEmail = "maichi@gmail.com";

            ViewBag.VmcMember = vmcMember;
            return View();
        }
    }
}

