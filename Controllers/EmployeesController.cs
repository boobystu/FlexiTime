using FlexiTime.Data;
using Microsoft.AspNetCore.Mvc;
using FlexiTime.Models;

namespace FlexiTime.Controllers
{
    public class EmployeesController : Controller
    {
        IEmployeeData _employeeData = new EmployeeData();
        public IActionResult Index(string name)
        {

            return View();

        }
    }
}