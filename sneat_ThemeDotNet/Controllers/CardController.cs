using Microsoft.AspNetCore.Mvc;

namespace sneat_ThemeDotNet.Controllers
{
    public class CardController : Controller
    {
        public IActionResult CardShow()
        {
            return View();
        }
    }
}
