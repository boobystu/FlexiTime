using Microsoft.AspNetCore.Mvc;
using FlexiTime.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using FlexiTime.ViewModels;

namespace FlexiTime.Controllers
{
    public class LocationsController : Controller
    {
        ILocationData _locationData = new LocationData();

        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            
            return View(await Task.Run(() => GetLocationViewModelList(id)));

        }

        private List<LocationViewModel> GetLocationViewModelList(string searchTerm)
        {
            var locationViewModels = new List<LocationViewModel>();

            foreach(var location in _locationData.GetLocationsByName(searchTerm))
            {
                var locationViewModel = new LocationViewModel();
                locationViewModel.Name = location.Name;
                locationViewModels.Add(locationViewModel);
            }

            return locationViewModels;
        }
    }
}