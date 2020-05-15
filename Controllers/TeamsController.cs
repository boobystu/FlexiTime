using FlexiTime.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FlexiTime.Data;
using System.Threading.Tasks;

namespace FlexiTime.Controllers
{
    public class TeamsController : Controller
    {
        ITeamData _teamData = new TeamData();
        
        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            return View(await Task.Run(() => GetTeamsViewModelList(id)));
        }

        private List<TeamViewModel> GetTeamsViewModelList(string searchTerm)
        {
            var teams = new List<TeamViewModel>();
            foreach(var team in _teamData.GetTeamsByName(searchTerm))
            {
                var teamViewModel = new TeamViewModel();
                teamViewModel.Name = team.Name;
                teamViewModel.Members = team.GetMemberNames();
                teams.Add(teamViewModel);
            }
            return teams;

        }
    }

}