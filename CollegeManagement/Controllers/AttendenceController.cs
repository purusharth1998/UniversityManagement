using DomainLayer.Model;
using Identity.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;

namespace CollegeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceController : ControllerBase
    {
        private readonly ICustomService<Attendence> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public AttendenceController(ICustomService<Attendence> customService, ApplicationDbContext applicationDbContext)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
        }

        [HttpPost(nameof(CreateAttendence))]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateAttendence(Attendence attendence)
        {
            if (attendence != null)
            {
                _customService.Insert(attendence);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }

        }
        [HttpGet(nameof(GetStudentAttendence))]
        public IActionResult GetStudentAttendence(int id)
        {
            var studentAttendence = from a in _applicationDbContext.Attendences
                                    join s in _applicationDbContext.Students on a.Id equals s.Id
                                    where s.Id == id
                                    select a.Ispresent;
            return Ok(studentAttendence);
        }
    }
}
