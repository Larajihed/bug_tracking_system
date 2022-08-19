using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bug_tracking_system.Database;
using bug_tracking_system.Models;
using AutoMapper;

namespace bug_tracking_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BugsController(DatabaseContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        

        // GET: api/Bugs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bug>>> GetBugs()
        {
          if (_context.Bugs == null)
          {
              return NotFound();
          }
            return Ok(_context.Bugs.Select(bug => _mapper.Map<BugDto>(bug)));
          //  return await  _context.Bugs.ToListAsync();
        }

        // GET: api/Bugs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bug>> GetBug(int id)
        {
          if (_context.Bugs == null)
          {
              return NotFound();
          }
            var bug = await _context.Bugs.FindAsync(id);

            if (bug == null)
            {
                return NotFound();
            }

            return bug;
        }

        // PUT: api/Bugs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBug(int id, Bug bug)
        {
            if (id != bug.BugId)
            {
                return BadRequest();
            }

            _context.Entry(bug).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bugs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bug>> PostBug(Bug newbug)
        {
            var bug = _mapper.Map<Bug>(newbug);

          if (_context.Bugs == null)
          {
              return Problem("Entity set 'DatabaseContext.Bugs'  is null.");
          }
            _context.Bugs.Add(bug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBug", new { id = bug.BugId }, bug);
        }

        // DELETE: api/Bugs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBug(int id)
        {
            if (_context.Bugs == null)
            {
                return NotFound();
            }
            var bug = await _context.Bugs.FindAsync(id);
            if (bug == null)
            {
                return NotFound();
            }

            _context.Bugs.Remove(bug);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BugExists(int id)
        {
            return (_context.Bugs?.Any(e => e.BugId == id)).GetValueOrDefault();
        }
    }
}
