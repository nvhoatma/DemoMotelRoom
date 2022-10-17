using DemoMotelRoom.DTO;
using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations;

namespace DemoMotelRoom.Models
{
    public partial class Department
    {
        [Required]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public ICollection<User> users { get; set; }
    }
}
