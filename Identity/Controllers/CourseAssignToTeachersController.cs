using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Identity.Auth;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseAssignToTeachersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseAssignToTeachersController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: api/CourseAssignToTeachers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CourseAssignToTeacher>>> GetCoursesAssignToTeachers()
        //{
        //    return await _context.CoursesAssignToTeachers.ToListAsync();
        //}

        //// GET: api/CourseAssignToTeachers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CourseAssignToTeacher>> GetCourseAssignToTeacher(int id)
        //{
        //    var courseAssignToTeacher = await _context.CoursesAssignToTeachers.FindAsync(id);

        //    if (courseAssignToTeacher == null)
        //    {
        //        return NotFound();
        //    }

        //    return courseAssignToTeacher;
        //}

        //// PUT: api/CourseAssignToTeachers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCourseAssignToTeacher(int id, CourseAssignToTeacher courseAssignToTeacher)
        //{
        //    if (id != courseAssignToTeacher.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(courseAssignToTeacher).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CourseAssignToTeacherExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/CourseAssignToTeachers
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<CourseAssignToTeacher>> PostCourseAssignToTeacher(CourseAssignToTeacher courseAssignToTeacher)
        //{
        //    _context.CoursesAssignToTeachers.Add(courseAssignToTeacher);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCourseAssignToTeacher", new { id = courseAssignToTeacher.Id }, courseAssignToTeacher);
        //}

        //// DELETE: api/CourseAssignToTeachers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCourseAssignToTeacher(int id)
        //{
        //    var courseAssignToTeacher = await _context.CoursesAssignToTeachers.FindAsync(id);
        //    if (courseAssignToTeacher == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.CoursesAssignToTeachers.Remove(courseAssignToTeacher);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CourseAssignToTeacherExists(int id)
        //{
        //    return _context.CoursesAssignToTeachers.Any(e => e.Id == id);
        //}
    }
}
