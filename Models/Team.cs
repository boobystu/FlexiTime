using System.Collections.Generic;

namespace FlexiTime.Models
{
    public class Team
    {
        public Team(int id, string name, List<Employee> members)
        {
            this.id = id;
            this.Name = name;
            this.Members = members;
        }
        private int id;

        public int TeamID{
            get
            {
                return this.id;
            }
        }
        public string Name{get;set;}

        public List<Employee> Members{get;set;}
    }
}