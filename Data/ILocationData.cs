using FlexiTime.Models;
using System.Collections.Generic;

namespace FlexiTime.Data
{
    public interface ILocationData
    {
        IEnumerable<Location> GetLocationsByName(string name = null);
        Location GetLocationById(int id);
        Location UpdateLocation(Location location);
        Location AddLocation(Location location);
        Location DeleteLocation(Location location);
    }
}