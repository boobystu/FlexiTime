using FlexiTime.Data;
using Microsoft.AspNetCore.Mvc;
using FlexiTime.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlexiTime.Models;

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
            return View(await Task.Run(() =>  _employeeData.GetEmployeeById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            _employeeData.UpdateEmployee(employee);
            
            return await Task.Run(() => RedirectToAction("Index"));
        }

        private List<EmployeeViewModel> GetEmployeeViewModelList(string SearchTerm)
        {
            var employees = new List<EmployeeViewModel>();

            foreach (var employee in _employeeData.GetEmployeesByName(SearchTerm))
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel(employee);
                
                employees.Add(employeeViewModel);
            }

            return employees;
        }

        private EmployeeViewModel GetEmployeeViewModelFromID(int id)
        {
            var employee = _employeeData.GetEmployeeById(id);

            var employeeViewModel = new EmployeeViewModel(employee);

            return employeeViewModel;
        }
    }
}
