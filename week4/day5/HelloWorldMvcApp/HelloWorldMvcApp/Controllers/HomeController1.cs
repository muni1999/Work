using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvcApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World MVC");
        }
    }
}
