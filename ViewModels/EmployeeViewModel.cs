using FlexiTime.Models;

namespace FlexiTime.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Forename{get;set;}
        public string Surname{get;set;}
        public string Email{get;set;}
        public string HomeOffice{get;set;}

        public EmployeeViewModel(Employee employee)
        {
            this.Id = employee.EmployeeID;
            this.Forename = employee.Forename;
            this.Surname = employee.Surname;
            this.Name = employee.FormattedName();
            this.Email = employee.Email;
        }
    }
}