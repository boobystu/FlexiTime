using System.Collections.Generic;
using FlexiTime.Models;
using System.Linq;

namespace FlexiTime.Data
{
    public class LocationData : ILocationData
    {
        List<Location> _locations;

        int _lastLocationID = 1;

        public LocationData()
        {
            _locations = new List<Location>()
            {
                new Location(_lastLocationID++, "Stockton"),
                new Location(_lastLocationID++, "Newcastle"),
                new Location(_lastLocationID++, "Wigan"),
                new Location(_lastLocationID++, "Manchester"),
                new Location(_lastLocationID++, "Heathrow"),
                new Location(_lastLocationID++, "Brighton"),
                new Location(_lastLocationID++, "Birmingham"),
                new Location(_lastLocationID++, "Leeds")
            };
        }
        public Location AddLocation(Location location)
        {
            //check id not already in use
            if (GetLocationById(location.LocationID) != null)
            {
                return null;
            }
            
            _locations.Add(location);

            return location;
        }

        public Location DeleteLocation(Location location)
        {
            //check location exists
            if (GetLocationById(location.LocationID) == null)
            {
                return null;
            }

            _locations.Remove(location);

            return location;
        }

        public Location GetLocationById(int id)
        {
            return _locations.Find(l => l.LocationID == id);
        }

        public IEnumerable<Location> GetLocationsByName(string name = null)
        {
            if(name == null)
            {
                return _locations;
            }

            name = name.ToLower();

            return from l in _locations
                    where l.Name.ToLower().Contains(name)
                    select l;
        }

        public Location UpdateLocation(Location location)
        {
            var loc = GetLocationById(location.LocationID);

            if(loc != null)
            {
                loc.Name = location.Name;
            }

            return loc;
        }
    }
}