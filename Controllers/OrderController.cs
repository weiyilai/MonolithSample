using Microsoft.AspNetCore.Mvc;

namespace MonolithSample.Controllers
{
    /// <summary>
    /// 訂單
    /// </summary>
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
