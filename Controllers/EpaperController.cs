using Microsoft.AspNetCore.Mvc;

namespace MonolithSample.Controllers
{
    public class EpaperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
