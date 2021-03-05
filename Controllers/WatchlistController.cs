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
    public class WatchlistController : Controller
    {
        private readonly WatchlistContext _context;

        public WatchlistController(WatchlistContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Watchlist>>> GetWatchlist()
        {
            return await _context.Watchlist.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Watchlist>> GetWatchlist(int id)
        {
            var watchlist = await _context.Watchlist.FindAsync(id);

            if (watchlist == null)
            {
                return NotFound();
            }

            return watchlist;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWatchlist(int id, Watchlist watchlist)
        {
            if (id != watchlist.Id)
            {
                return BadRequest();
            }
            _context.Entry(watchlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WatchlistExists(id))
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
        public async Task<ActionResult<Watchlist>> PostWatchlist(Watchlist watchlist)
        {
            _context.Watchlist.Add(watchlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWatchlist), new { id = watchlist.Id }, watchlist);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Watchlist>> DeleteWatchlist(int id)
        {
            var watchlist = await _context.Watchlist.FindAsync(id);
            if (watchlist == null)
            {
                return NotFound();
            }
            _context.Watchlist.Remove(watchlist);
            await _context.SaveChangesAsync();

            return watchlist;
        }

        private bool WatchlistExists(int id)
        {
            return _context.Watchlist.Any(e => e.Id == id);
        }
    }
}