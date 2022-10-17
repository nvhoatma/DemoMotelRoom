using DemoMotelRoom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace DemoMotelRoom.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly MotelRoomContext _context;

        public UsersRepository(MotelRoomContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            
                var checkEmail = from n in _context.users.Where(n => n.email == user.email)
                                 select n;
                if (checkEmail.Any())
                {
                        throw new Exception("Can not");

                 }
                _context.users.Add(user);
                await _context.SaveChangesAsync();
                return user;
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _context.users.FindAsync(id);
             _context.users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> Get()
        {
              return await _context.users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetNameUser(string LastName)
        {
            var findName = from n in _context.users.Where(n => n.lastName == LastName)
                           select n;
            return findName.ToList();
        }

        public async Task Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
