using DomainLayer.Model;
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
    public class TeacherController : ControllerBase
    {
        private readonly ICustomService<Teacher> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public TeacherController(ICustomService<Teacher> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet(nameof(GetTeacherById))]
        //[Authorize(Roles = "User")]
        public IActionResult GetTeacherById(int Id)
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
        [HttpGet(nameof(GetAllTeacher))]
        public IActionResult GetAllTeacher()
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
        [HttpPost(nameof(CreateTeacher))]
        //[Authorize(Roles = "Admin")]

        public IActionResult CreateTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _customService.Insert(teacher);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateTeacher))]
        //[Authorize(Roles = "Admin")]

        public IActionResult UpdateTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _customService.Update(teacher);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteTeacher))]
        //[Authorize(Roles = "Admin")]

        public IActionResult DeleteTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _customService.Delete(teacher);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }

    }
}
