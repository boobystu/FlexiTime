using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FlexiTime.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}