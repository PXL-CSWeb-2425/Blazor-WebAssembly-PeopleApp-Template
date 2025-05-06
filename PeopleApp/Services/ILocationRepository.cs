using PeopleApp.Models;

namespace PeopleApp.Services
{
    public interface ILocationRepository
    {
        
            void AddLocation(Location l);
            IEnumerable<Location> GetLocations();
        
    }
}
