using Microsoft.AspNetCore.Mvc;
using MiniMvcApp.Models;

namespace MiniMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();

        [HttpGet]
        public IActionResult Contact() => View(new ContactModel());

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Msg = "Submitted!";
                return View(new ContactModel());
            }
            return View(model);
        }
    }
}
