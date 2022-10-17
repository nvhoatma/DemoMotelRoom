using DemoMotelRoom.DTO;
using DemoMotelRoom.Models;

namespace DemoMotelRoom.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable< ProductInformation> Get();
        Task<Department> GetById(int id);
        Task<IEnumerable<Department>> GetNameUser(string name);
        Task<Department> Create(Department department);
        Task Update(Department department);
        Task Delete(int id);
    }
}
