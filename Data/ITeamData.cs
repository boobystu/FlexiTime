using FlexiTime.Models;
using System.Collections.Generic;

namespace FlexiTime.Data
{
    public interface ITeamData
    {
        IEnumerable<Team> GetTeamsByName(string name = null);
        Team GetTeamById(int id);
        Team UpdateTeam(Team team);
        Team AddTeam(Team team);
        Team DeleteTeam(Team team);
    }
}