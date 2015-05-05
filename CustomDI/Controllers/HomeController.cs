
using Microsoft.AspNet.Mvc;
using Di.Core.Interfaces;

namespace CustomDI.Controllers
{
    public class HomeController : Controller
    {
               private readonly IUserService Service;

        public HomeController(IUserService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            var users = Service.GetAll();
         
            return View(users);
        }


        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}