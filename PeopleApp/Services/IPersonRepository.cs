using PeopleApp.Models;

namespace PeopleApp.Services
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(long id);
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
        void Delete(long id);
    }

}
