using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMotelRoom.Models
{
    public partial  class User
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Nhap sai dinh dang email")]
        public string email { get; set; }
        public int departmentId { get; set; }
    }
}
