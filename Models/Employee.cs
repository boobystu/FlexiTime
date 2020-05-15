namespace FlexiTime.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(int id, string forename, string surname, Location office, string email)
        {
            this.id = id;
            this.Forename = forename;
            this.Surname = surname;
            this.HomeOffice = office;
            this.Email = email;
        }
        private int id;

        public int EmployeeID
        {
            get
            {
                return this.id;
            }
        }
        public string Forename{get;set;}
        public string Surname{get;set;}
        public Location HomeOffice{get;set;}
        public string Email{get;set;}

        public string FormattedName()
        {
            return Forename + " " + Surname;
        }
    }
}