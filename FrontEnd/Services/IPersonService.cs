using DataLayer;

namespace FrontEnd.Services
{
    public interface IPersonService
    {
        Task AddPersonAsync(Person person);
    }
}
