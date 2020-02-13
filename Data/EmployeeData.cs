using System.Collections.Generic;
using FlexiTime.Models;
using System.Linq;

namespace FlexiTime.Data
{
    public class EmployeeData : IEmployeeData
    {
        List<Employee> _employees;

        ILocationData _locationData;

        int _lastEmpID;

        public EmployeeData()
        {
            _locationData = new LocationData();

            _lastEmpID = 1;

            _employees = new List<Employee>()
            {
                new Employee(_lastEmpID++, "Sebastien", "Vettel", _locationData.GetLocationById(1), "SebastienVettel@iris.co.uk"),
                new Employee(_lastEmpID++, "Charles", "LeClerc", _locationData.GetLocationById(1), "CharlesLeClerc@iris.co.uk"),
                new Employee(_lastEmpID++, "Lewis", "Hamilton", _locationData.GetLocationById(1), "LewisHamilton@iris.co.uk"),
                new Employee(_lastEmpID++, "Valterri", "Bottas", _locationData.GetLocationById(1), "ValterriBottas@iris.co.uk"),
                new Employee(_lastEmpID++, "Max", "Verstappen", _locationData.GetLocationById(2), "MaxVerstappen@iris.co.uk"),
                new Employee(_lastEmpID++, "Alexander", "Albon", _locationData.GetLocationById(2), "AlexanderAlbon@iris.co.uk"),
                new Employee(_lastEmpID++, "Carlos", "Sainz", _locationData.GetLocationById(2), "CarlosSainz@iris.co.uk"),
                new Employee(_lastEmpID++, "Lando", "Norris", _locationData.GetLocationById(2), "LandoNorris@iris.co.uk"),
                new Employee(_lastEmpID++, "Daniel", "Ricciardo", _locationData.GetLocationById(3), "DanielRicciardo@iris.co.uk"),
                new Employee(_lastEmpID++, "Esteban", "Ocon", _locationData.GetLocationById(3), "EstebanOcon@iris.co.uk"),
                new Employee(_lastEmpID++, "Pierre", "Gasly", _locationData.GetLocationById(3), "PierreGasly@iris.co.uk"),
                new Employee(_lastEmpID++, "Daniil", "Kvyat", _locationData.GetLocationById(3), "DaniilKvyat@iris.co.uk"),
                new Employee(_lastEmpID++, "Sergio", "Perez", _locationData.GetLocationById(4), "SergioPerez@iris.co.uk"),
                new Employee(_lastEmpID++, "Lance", "Stroll", _locationData.GetLocationById(4), "LanceStroll@iris.co.uk"),
                new Employee(_lastEmpID++, "Kimi", "Raikkonen", _locationData.GetLocationById(4), "KimiRaikkonen"),
                new Employee(_lastEmpID++, "Antonio", "Giovinazzi", _locationData.GetLocationById(4), "AntonioGiovinazzi@iris.co.uk"),
                new Employee(_lastEmpID++, "Romain", "Grosjean", _locationData.GetLocationById(5), "RomainGrosjean@iris.co.uk"),
                new Employee(_lastEmpID++, "Kevin", "Magnussen", _locationData.GetLocationById(5), "KevinMagnussen@iris.co.uk"),
                new Employee(_lastEmpID++, "George", "Russel", _locationData.GetLocationById(5), "GeorgeRussel@iris.co.uk"),
                new Employee(_lastEmpID++, "Nicholas", "Latifi", _locationData.GetLocationById(5), "NicholasLatifi@iris.co.uk")
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            int empID = employee.EmployeeID;

            if(GetEmployeeById(empID) != null)
            {
                empID = _lastEmpID++;
            }
            _employees.Add(new Employee(empID, 
                                        employee.Forename, 
                                        employee.Surname, 
                                        employee.HomeOffice, 
                                        employee.Email));

            return GetEmployeeById(empID);
        }

        public Employee DeleteEmployee(Employee employee)
        {
            var emp = GetEmployeeById(employee.EmployeeID);

            if(emp != null)
            {
                _employees.Remove(emp);
            }

            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.Find(e => e.EmployeeID == id);
        }

        public IEnumerable<Employee> GetEmployeesByName(string name)
        {
            if(name == null)
            {
                return _employees;
            }

            name = name.ToLower();

            return from e in _employees
                    where (e.Forename.ToLower().Contains(name)
                          || e.Surname.ToLower().Contains(name))
                    select e;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var emp = GetEmployeeById(employee.EmployeeID);

            if(emp != null)
            {
                emp.Email = employee.Email;
                emp.Forename = employee.Forename;
                emp.HomeOffice = employee.HomeOffice;
                emp.Surname = employee.Surname;
            }

            return emp;
        }
    }
}