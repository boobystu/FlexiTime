using FlexiTime.Data;
using Microsoft.AspNetCore.Mvc;
using FlexiTime.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexiTime.Controllers
{

    public class EmployeesController : Controller
    {
        IEmployeeData _employeeData = new EmployeeData();
        
        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {

            return View(await Task.Run(() => GetEmployeeViewModelList(id)));
                
        }

        private List<EmployeeViewModel> GetEmployeeViewModelList(string SearchTerm)
        {
            var employees = new List<EmployeeViewModel>();

            foreach (var employee in _employeeData.GetEmployeesByName(SearchTerm))
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Name = employee.FormattedName();
                employeeViewModel.HomeOffice = employee.HomeOffice.Name;
                employeeViewModel.Email = employee.Email;
                employees.Add(employeeViewModel);
            }

            return employees;
        }
    }
}
