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

        public async Task<IActionResult> Edit(int id)
        {
            return View(await Task.Run(() => GetEmployeeViewModelFromID(id)));
        }

        private List<EmployeeViewModel> GetEmployeeViewModelList(string SearchTerm)
        {
            var employees = new List<EmployeeViewModel>();

            foreach (var employee in _employeeData.GetEmployeesByName(SearchTerm))
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = employee.EmployeeID;
                employeeViewModel.Name = employee.FormattedName();
                employeeViewModel.HomeOffice = employee.HomeOffice.Name;
                employeeViewModel.Email = employee.Email;
                employees.Add(employeeViewModel);
            }

            return employees;
        }

        private EmployeeViewModel GetEmployeeViewModelFromID(int id)
        {
            var employeeViewModel = new EmployeeViewModel();

            var employee = _employeeData.GetEmployeeById(id);

            employeeViewModel.Id = employee.EmployeeID;
            employeeViewModel.Forename = employee.Forename;
            employeeViewModel.Surname = employee.Surname;
            employeeViewModel.Email = employee.Email;

            return employeeViewModel;
        }
    }
}
