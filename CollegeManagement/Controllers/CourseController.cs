using DomainLayer.Models;
using Identity.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICustomService<Course> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public CourseController(ICustomService<Course> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet(nameof(GetCourseById))]
        [Authorize(Roles = "User")]
        public IActionResult GetCourseById(int Id)
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
        [HttpGet(nameof(GetAllCourse))]
        public IActionResult GetAllCourse()
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
        [HttpPost(nameof(CreateCourse))]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateCourse(Course course)
        {
            if (course != null)
            {
                _customService.Insert(course);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateCourse))]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateCourse(Course course)
        {
            if (course != null)
            {
                _customService.Update(course);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteCourse))]
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteCourse(Course course)
        {
            if (course != null)
            {
                _customService.Delete(course);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}

