using Identity.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AttendencesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: api/Attendences
        //[Authorize(Roles = UserRoles.User)]
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Attendence>>> GetAttendences()
        //{
        //    return await _context.Attendences.ToListAsync();
        //}

        //// GET: api/Attendences/5
        //[Authorize(Roles = UserRoles.User)]

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Attendence>> GetAttendence(int id)
        //{
        //    var attendence = await _context.Attendences.FindAsync(id);

        //    if (attendence == null)
        //    {
        //        return NotFound();
        //    }

        //    return attendence;
        //}

        //// PUT: api/Attendences/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[Authorize(Roles = UserRoles.Admin)]
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAttendence(int id, Attendence attendence)
        //{
        //    if (id != attendence.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(attendence).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AttendenceExists(id))
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

        //// POST: api/Attendences
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[Authorize(Roles = UserRoles.Admin)]
        //[HttpPost]
        //public async Task<ActionResult<Attendence>> PostAttendence(Attendence attendence)
        //{
        //    _context.Attendences.Add(attendence);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAttendence", new { id = attendence.Id }, attendence);
        //}

        //// DELETE: api/Attendences/5
        //[Authorize(Roles = UserRoles.Admin)]

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAttendence(int id)
        //{
        //    var attendence = await _context.Attendences.FindAsync(id);
        //    if (attendence == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Attendences.Remove(attendence);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AttendenceExists(int id)
        //{
        //    return _context.Attendences.Any(e => e.Id == id);
        //}
    }
}
