namespace PeopleApp.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Person> People { get; set; }
    }
}
