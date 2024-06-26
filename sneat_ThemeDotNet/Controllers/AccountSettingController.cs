using Microsoft.AspNetCore.Mvc;

namespace sneat_ThemeDotNet.Controllers
{
    public class AccountSettingController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult Connection()
        {
            return View();
        }
    }
}
