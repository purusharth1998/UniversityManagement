using DomainLayer.Models;
using Identity.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ICustomService<Student> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentController(ICustomService<Student> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }

        
        [HttpGet(nameof(GetStudentById))]
        [Authorize(Roles = "User")]
        public IActionResult GetStudentById(int StudentId)
        {
            var obj = _customService.Get(StudentId);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllStudent))]
        public IActionResult GetAllStudent()
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
        [HttpPost(nameof(CreateStudent))]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateStudent(Student student)
        {
            if (student != null)
            {
                _customService.Insert(student);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateStudent))]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateStudent(Student student)
        {
            if (student != null)
            {
                _customService.Update(student);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteStudent))]
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteStudent(Student student)
        {
            if (student != null)
            {
                _customService.Delete(student);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }

        [HttpGet(nameof(GetStudentCourse))]
        [Authorize(Roles = "User")]

        public IActionResult GetStudentCourse(int id)
        {
            var studentCourse = from c in _applicationDbContext.Courses
                                    join s in _applicationDbContext.Students on c.Id equals s.Id
                                    where c.Id == id
                                    select s.Name;
            return Ok(studentCourse);
        }
    }
}
