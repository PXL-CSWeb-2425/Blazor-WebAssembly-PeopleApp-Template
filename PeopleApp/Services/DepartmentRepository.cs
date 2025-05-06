using PeopleApp.Data;
using PeopleApp.Models;

namespace PeopleApp.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _context;
        public DepartmentRepository(DataContext context)
        {
            _context = context;
        }        
        public void AddDepartment(Department d)
        {
            _context.Departments.Add(d);
            _context.SaveChanges();
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments;
        }

        public Department GetDepartment(int id)
        {
            return _context.Departments.Find(id);
        }
    }
}
