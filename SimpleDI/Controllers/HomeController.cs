
using Di.Core.Interfaces;
using Di.Core.Services;
using Microsoft.AspNet.Mvc;

namespace SimpleDI.Controllers
{
    public class HomeController : Controller
    {
        [Activate]
        public IUserService UserService { get; set; }


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