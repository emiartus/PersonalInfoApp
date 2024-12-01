using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class Person
    {
        public int Id { get; set; }
        public DateTime InsertedTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? PersonalIdNumber { get; set; }
        public string Email { get; set; }
        public Country CountryOfOrigin { get; set; }
        public Gender Gender { get; set; }
    }
}
