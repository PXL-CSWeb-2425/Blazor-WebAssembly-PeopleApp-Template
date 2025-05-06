using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class Person
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MinLength(3, ErrorMessage = "First name must be at least 3 characters long")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [MinLength(3, ErrorMessage = "Surname must be at least 3 characters long")]
        public string Surname { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Department must be set")]
        public long DepartmentId { get; set; }
        public Department Department { get; set; }


        public Location Location { get; set; }
        public long LocationId { get; set; }
    }
}
