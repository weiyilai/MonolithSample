using Microsoft.AspNetCore.Mvc;

namespace MonolithSample.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
