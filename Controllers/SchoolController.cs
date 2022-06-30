using Microsoft.AspNetCore.Mvc;

namespace PostExample.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
