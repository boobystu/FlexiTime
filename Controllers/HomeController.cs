using FlexiTime.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlexiTime.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            // var homeViewModel = new HomeViewModel();

            //return View(homeViewModel);
            return View();
        }

        // public string Index()
        // {
        //     return "home controller";
        // }

    }
}