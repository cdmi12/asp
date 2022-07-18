using first.Models;
using Microsoft.AspNetCore.Mvc;

namespace first.Controllers
{
    public class SumController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]  /* ( argument ) */
        public IActionResult Add(addition addition)
        {
            ViewBag.total = addition.a + addition.b;

            return View(addition);
        }
    }
}
