using Microsoft.AspNetCore.Mvc;

namespace MonolithSample.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
