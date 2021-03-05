using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TecTradeAPI.Models;

namespace TecTradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : Controller
    {
        private readonly WatchContext _context;

        public WatchController(WatchContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Watch>>> GetWatch()
        {
            return await _context.Watch.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Watch>> GetWatch(int id)
        {
            var watch = await _context.Watch.FindAsync(id);

            if (watch == null)
            {
                return NotFound();
            }

            return watch;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWatch(int id, Watch watch)
        {
            if (id != watch.Id)
            {
                return BadRequest();
            }
            _context.Entry(watch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WatchExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Watch>> PostWatch(Watch watch)
        {
            _context.Watch.Add(watch);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWatch), new { id = watch.Id }, watch);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Watch>> DeleteWatch(int id)
        {
            var watch = await _context.Watch.FindAsync(id);
            if (watch == null)
            {
                return NotFound();
            }
            _context.Watch.Remove(watch);
            await _context.SaveChangesAsync();

            return watch;
        }

        private bool WatchExists(int id)
        {
            return _context.Watch.Any(e => e.Id == id);
        }
    }
}
