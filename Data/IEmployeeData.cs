using System.Collections.Generic;
using FlexiTime.Models;

namespace FlexiTime.Data
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployeesByName(string name = null);
        Employee GetEmployeeById(int id);
        Employee UpdateEmployee(Employee employee);
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(Employee employee);
    }
}