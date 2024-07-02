using Microsoft.AspNetCore.Mvc;

namespace sneat_ThemeDotNet.Controllers
{
    public class FormController : Controller
    {
        public IActionResult BasicInput()
        {
            return View();
        }
        public IActionResult InputGroup()
        {
            return View();
        }
    }
}
