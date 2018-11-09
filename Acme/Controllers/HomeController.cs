using Microsoft.AspNetCore.Mvc;

namespace Acme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return Content("In homecontroller/index " + id);
        }
    }
}