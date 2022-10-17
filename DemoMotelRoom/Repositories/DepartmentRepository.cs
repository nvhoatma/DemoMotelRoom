using DemoMotelRoom.DTO;
using DemoMotelRoom.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMotelRoom.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MotelRoomContext _context;

        public DepartmentRepository(MotelRoomContext context)
        {
            _context = context;
        }

        public async Task<Department> Create(Department department)
        {
            _context.department.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<ProductInformation> Get()
        {
            //return await _context.department
            //    .AsNoTracking()
            //    .Include(i => i.Users)
            //    .ToListAsync();

            var departmentGet = (from p in _context.department
                                 join pm in _context.users on p.DepartmentId equals pm.departmentId
                                 select new ProductInformation()
                                 {
                                     DepartmentId = p.DepartmentId,
                                     Name = p.Name,
                                     Descriptions = p.Descriptions,
                                     firstName = pm.firstName,
                                     lastName = pm.lastName
                                 }).ToList();
            return departmentGet;
        }

        public Task<Department> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetNameUser(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Department department)
        {
            _context.Entry(department).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
