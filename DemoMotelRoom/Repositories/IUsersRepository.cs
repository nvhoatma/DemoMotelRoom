using DemoMotelRoom.Models;

namespace DemoMotelRoom.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> GetById(int id);
        Task<IEnumerable<User>> GetNameUser(string LastName);
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
