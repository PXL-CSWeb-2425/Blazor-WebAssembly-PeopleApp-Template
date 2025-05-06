using PeopleApp.Models;

namespace PeopleApp.Services
{
    public interface IDepartmentRepository
    {
        void AddDepartment(Department d);
        IEnumerable<Department> GetDepartments();

        Department GetDepartment(int id);
    }
}
