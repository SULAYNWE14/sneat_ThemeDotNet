using Microsoft.AspNetCore.Mvc;

namespace sneat_ThemeDotNet.Controllers
{
    public class FormLayoutController : Controller
    {
        public IActionResult VerticalForm()
        {
            return View();
        }
        public IActionResult HorizontalForm() {
            return View();
        }

    }
}
