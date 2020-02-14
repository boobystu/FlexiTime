using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FlexiTime.Data;
using FlexiTime.Models;
using System.Collections.Generic;

namespace FlexiTime.Views.Employees
{
    
    public class IndexModel : PageModel
    {
        private readonly IEmployeeData employeeData;

        public IEnumerable<Employee> Employees { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public IndexModel(IEmployeeData employeeData)
        {
            SearchTerm = "";
            this.employeeData = employeeData;
        }

        public void OnGet()
        {
            Employees = employeeData.GetEmployeesByName(SearchTerm);
        }
    }
}