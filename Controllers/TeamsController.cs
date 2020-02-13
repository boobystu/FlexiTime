using FlexiTime.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlexiTime.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}