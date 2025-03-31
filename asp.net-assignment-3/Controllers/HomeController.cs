using Microsoft.AspNetCore.Mvc;

namespace asp.net_assignment_3.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
