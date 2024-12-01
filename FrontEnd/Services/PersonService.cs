using DataLayer;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace FrontEnd.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public async Task AddPersonAsync(Person person)
        {
            try
            {
                await _personRepository.AddPersonRecordAsync(person);
            }
            catch (Exception ex)
            {
                // Log and handle the exception
                Console.WriteLine($"Service error: {ex.Message}");
                throw new ApplicationException("An error occurred while adding the product.");
            }
        }
    }
}
