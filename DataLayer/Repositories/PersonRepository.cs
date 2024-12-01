using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDbContext _context;

        public PersonRepository(PersonDbContext context)
        {
            _context = context;
        }

        public async Task AddPersonRecordAsync(Person person)
        {
            try
            {
                person.InsertedTime = DateTime.Now;
                _context.Persons.Add(person);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("An error occurred while adding the product.");
            }
        }

        public class ProductRepository
        {

        }
    }
}
