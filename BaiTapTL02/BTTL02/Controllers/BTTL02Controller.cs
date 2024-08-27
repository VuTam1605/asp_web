using Microsoft.AspNetCore.Mvc;

namespace BTTL02.Controllers
{
    public class BTTL02Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
