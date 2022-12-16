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
    public class ResultController : ControllerBase
    {
            private readonly ICustomService<Result> _customService;
            private readonly ApplicationDbContext _applicationDbContext;
            public ResultController(ICustomService<Result> customService, ApplicationDbContext applicationDbContext)
            {
                _customService = customService;
                _applicationDbContext = applicationDbContext;
            }


            [HttpGet(nameof(GetResultById))]
        [Authorize(Roles = "User")]
        public IActionResult GetResultById(int Id)
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
            [HttpGet(nameof(GetAllResult))]
            public IActionResult GetAllResult()
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
            [HttpPost(nameof(CreateResult))]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateResult(Result result)
            {
                if (result != null)
                {
                    _customService.Insert(result);
                    return Ok("Created Successfully");
                }
                else
                {
                    return BadRequest("Somethingwent wrong");
                }
            }
            [HttpPost(nameof(UpdateResult))]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateResult(Result result)
            {
                if (result != null)
                {
                    _customService.Update(result);
                    return Ok("Updated SuccessFully");
                }
                else
                {
                    return BadRequest();
                }
            }
            [HttpDelete(nameof(DeleteResult))]
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteResult(Result result)
            {
                if (result != null)
                {
                    _customService.Delete(result);
                    return Ok("Deleted Successfully");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
        }
}
