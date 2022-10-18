using Microsoft.AspNetCore.Mvc;

namespace Ustora.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/dashboard")]
    public class DashBoardController : Controller
    {
        [Route("")] 
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
