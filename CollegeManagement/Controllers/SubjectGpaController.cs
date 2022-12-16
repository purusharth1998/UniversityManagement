using DomainLayer.Models;
using Identity.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectGpaController : ControllerBase
    {
        private readonly ICustomService<SubjectGpa> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public SubjectGpaController(ICustomService<SubjectGpa> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }


        [HttpGet(nameof(GetSubjectGpaById))]
        //[Authorize(Roles = "User")]
        public IActionResult GetSubjectGpaById(int Id)
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
        [HttpGet(nameof(GetAllSubjectGpa))]
        public IActionResult GetAllSubjectGpa()
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
        [HttpPost(nameof(CreateSubjectGpa))]
        //[Authorize(Roles = "Admin")]

        public IActionResult CreateSubjectGpa(SubjectGpa subjectGpa)
        {
            if (subjectGpa != null)
            {
                _customService.Insert(subjectGpa);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateSubjectGpa))]
        //[Authorize(Roles = "Admin")]

        public IActionResult UpdateSubjectGpa(SubjectGpa subjectGpa)
        {
            if (subjectGpa != null)
            {
                _customService.Update(subjectGpa);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteSubjectGpa))]
        //[Authorize(Roles = "Admin")]

        public IActionResult DeleteSubjectGpa(SubjectGpa subjectGpa)
        {
            if (subjectGpa != null)
            {
                _customService.Delete(subjectGpa);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
