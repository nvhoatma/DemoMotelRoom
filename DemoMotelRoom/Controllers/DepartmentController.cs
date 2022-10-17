using AutoMapper;
using DemoMotelRoom.DTO;
using DemoMotelRoom.Models;
using DemoMotelRoom.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMotelRoom.Controllers
{
    [Route("test/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _repository;
        
        public DepartmentController(IDepartmentRepository repository)
        {
            this._repository = repository;   
        }
        [HttpGet]
        public  IEnumerable<ProductInformation> GetAllDepartment( )
        {
            return  _repository.Get().ToList();
        }
        [HttpPost]
        public async Task<ActionResult> PostDepartment([FromBody] Department department)
        {   
            var newdepartment = await _repository.Create(department);
            return CreatedAtAction(nameof(GetAllDepartment), new { id = department.DepartmentId },department);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> PutDepartment(int id, [FromBody] Department department)
        {
            await _repository.Update(department);
            return NoContent();
        }
    }
}
