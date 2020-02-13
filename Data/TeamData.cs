using FlexiTime.Models;
using System.Collections.Generic;
using System.Linq;

namespace FlexiTime.Data
{
    public class TeamData : ITeamData
    {
        List<Team> _teams;

        int _lastTeamID;

        IEmployeeData _employeeData;
        public TeamData()
        {
            _lastTeamID = 1;
            
            _employeeData = new EmployeeData();

            _teams = new List<Team>()
            {
                new Team(_lastTeamID++, "Ferrari", new List<Employee>(){_employeeData.GetEmployeeById(1),
                                                                        _employeeData.GetEmployeeById(2),
                                                                        _employeeData.GetEmployeeById(15),
                                                                        _employeeData.GetEmployeeById(16),
                                                                        _employeeData.GetEmployeeById(17),
                                                                        _employeeData.GetEmployeeById(18)}),
                new Team(_lastTeamID++, "Mercedes", new List<Employee>(){_employeeData.GetEmployeeById(3),
                                                                        _employeeData.GetEmployeeById(4),
                                                                        _employeeData.GetEmployeeById(7),
                                                                        _employeeData.GetEmployeeById(8),
                                                                        _employeeData.GetEmployeeById(13),
                                                                        _employeeData.GetEmployeeById(14),
                                                                        _employeeData.GetEmployeeById(19),
                                                                        _employeeData.GetEmployeeById(20)}),
                new Team(_lastTeamID++, "Renault", new List<Employee>(){_employeeData.GetEmployeeById(9),
                                                                        _employeeData.GetEmployeeById(10)}),
                new Team(_lastTeamID++, "Honda", new List<Employee>(){_employeeData.GetEmployeeById(5),
                                                                        _employeeData.GetEmployeeById(6),
                                                                        _employeeData.GetEmployeeById(11),
                                                                        _employeeData.GetEmployeeById(12)})
            };
            
        }

        public Team AddTeam(Team team)
        {
            int teamID = team.TeamID;

            if(GetTeamById(teamID) != null)
            {
                teamID = _lastTeamID++;
            }
            _teams.Add(new Team(teamID, 
                                team.Name,
                                team.Members));

            return GetTeamById(teamID);
        }

        public Team DeleteTeam(Team team)
        {
            throw new System.NotImplementedException();
        }

        public Team GetTeamById(int id)
        {
            return _teams.Find(t => t.TeamID == id);
        }

        public IEnumerable<Team> GetTeamsByName(string name = null)
        {
            if(name == null)
            {
                return _teams;
            }

            name = name.ToLower();

            return from t in _teams
                    where t.Name.ToLower().Contains(name)
                    select t;
        }

        public Team UpdateTeam(Team team)
        {
            var tm = GetTeamById(team.TeamID);

            if(tm != null)
            {
                tm.Name = team.Name;
                tm.Members = team.Members;
            }

            return tm;
        }
    }
}