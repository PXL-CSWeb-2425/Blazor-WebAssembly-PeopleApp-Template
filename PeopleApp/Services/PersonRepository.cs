using Microsoft.EntityFrameworkCore;
using PeopleApp.Data;
using PeopleApp.Models;

namespace PeopleApp.Services
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;
        public PersonRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetAll()
        {
            return _context.People.Include(p => p.Department)
        .Include(p => p.Location).ToList();
        }
        public Person GetById(long id)
        {
            return _context.People.Include(p => p.Department)
          .Include(p => p.Location)
          .FirstOrDefault(p => p.Id == id);
        }

        public void Add(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }
        public void Update(Person person)
        {
            _context.People.Update(person);
            _context.SaveChanges();
        }
        public void Delete(Person person)
        {
            _context.People.Remove(person);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var person = this.GetById(id);

            _context.People.Remove(person);
            _context.SaveChanges();
        }
    }
}
