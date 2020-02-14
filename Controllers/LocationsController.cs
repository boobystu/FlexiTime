using Microsoft.AspNetCore.Mvc;
using FlexiTime.Data;
using FlexiTime.Models;

namespace FlexiTime.Controllers
{
    public class LocationsController : Controller
    {
        ILocationData _locationData = new LocationData();
        public IActionResult Index(string name)
        {
            // var locationViewModel = new LocationViewModel
            // {
            //     ListOfLocations = _locationData.GetLocationsByName(name)
            // };

            // return View(locationViewModel);

            return View();

        }
    }
}