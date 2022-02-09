using Microsoft.AspNetCore.Mvc;

namespace prueba.Controllers
{
    [Route("/manage")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
