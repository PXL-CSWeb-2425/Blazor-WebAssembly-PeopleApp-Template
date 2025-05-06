using Microsoft.EntityFrameworkCore;
using PeopleApp.Models;

namespace PeopleApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
