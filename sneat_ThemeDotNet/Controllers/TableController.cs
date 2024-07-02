using Microsoft.AspNetCore.Mvc;

namespace sneat_ThemeDotNet.Controllers
{
    public class TableController : Controller
    {
        public IActionResult TableShow()
        {
            return View();
        }
    }
}
