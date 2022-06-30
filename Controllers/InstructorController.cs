using Microsoft.AspNetCore.Mvc;

namespace PostExample.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View(Database.Instructors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Title)
        {
            Database.CreateInstructor(Name);
            return RedirectToAction("Create");
        }
    }
}
