using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRatingBackend.Models;

namespace MovieRatingBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public WatchlistsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Watchlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Watchlist>>> GetWatchlists()
        {
            return await _context.Watchlists.ToListAsync();
        }

        // GET: api/Watchlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Watchlist>> GetWatchlist(int id)
        {
            var watchlist = await _context.Watchlists.FindAsync(id);

            if (watchlist == null)
            {
                return NotFound();
            }

            return watchlist;
        }

        // PUT: api/Watchlists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // POST: api/Watchlists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Watchlist>> PostWatchlist(Watchlist watchlist)
        {
            _context.Watchlists.Add(watchlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWatchlist", new { id = watchlist.Id }, watchlist);
        }

        // DELETE: api/Watchlists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Watchlist>> DeleteWatchlist(int id)
        {
            var watchlist = await _context.Watchlists.FindAsync(id);
            if (watchlist == null)
            {
                return NotFound();
            }

            _context.Watchlists.Remove(watchlist);
            await _context.SaveChangesAsync();

            return watchlist;
        }

        private bool WatchlistExists(int id)
        {
            return _context.Watchlists.Any(e => e.Id == id);
        }
    }
}
