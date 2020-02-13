using FlexiTime.Models;
using System.Collections.Generic;

namespace FlexiTime.Data
{
    public class TeamData : ITeamData
    {
        List<Team> _teams;

        int _lastTeamID;

        public TeamData()
        {
            _lastTeamID = 1;
            
        }

        public Team AddTeam(Team team)
        {
            throw new System.NotImplementedException();
        }

        public Team DeleteTeam(Team team)
        {
            throw new System.NotImplementedException();
        }

        public Team GetTeamById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Team> GetTeamsByName(string name = null)
        {
            throw new System.NotImplementedException();
        }

        public Team UpdateTeam(Team team)
        {
            throw new System.NotImplementedException();
        }
    }
}