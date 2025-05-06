using PeopleApp.Data;
using PeopleApp.Models;

namespace PeopleApp.Services
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DataContext _context;
        public LocationRepository(DataContext context)
        {
            _context = context;
        }
        public void AddLocation(Location l)
        {
            _context.Locations.Add(l);
            _context.SaveChanges();
        }

        public IEnumerable<Location> GetLocations()
        {
            return _context.Locations;
        }
    }
}
