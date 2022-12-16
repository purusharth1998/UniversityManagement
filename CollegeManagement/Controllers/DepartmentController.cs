using DomainLayer.Models;
using Identity.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using System.Data;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ICustomService<Department> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public DepartmentController(ICustomService<Department> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet(nameof(GetDepartmentById))]
        [Authorize(Roles = "User")]
        public IActionResult GetDepartmentById(int Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllDepartment))]
        public IActionResult GetAllDepartment()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateDepartment))]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateDepartment(Department department)
        {
            if (department != null)
            {
                _customService.Insert(department);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateDepartment))]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateDepartment(Department department)
        {
            if (department != null)
            {
                _customService.Update(department);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteDepartment))]
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteDepartment(Department department)
        {
            if (department != null)
            {
                _customService.Delete(department);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
        [HttpGet(nameof(GetStudentDepartment))]
        public IActionResult GetStudentDepartment(int id)
        {
            var studentDepartment = from d in _applicationDbContext.Departments
                                    join s in _applicationDbContext.Students on d.Id equals s.Id
                                    where d.Id == id
                                    select s.Name;
            return Ok(studentDepartment);
        }
    }
}
