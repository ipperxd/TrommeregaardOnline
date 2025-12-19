using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trommeregaard.API.Data;
using Trommeregaard.API.Models;
using Trommeregaard.API.Service;

namespace Trommeregaard.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CowsController(ICowService _cowService) : ControllerBase
    {
        // GET: api/Cows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cow>>> GetCow()
        {
            IEnumerable<Cow> cows = await _cowService.GetAllCowsAsync();

            return Ok(cows);
        }
        /*

        // GET: api/Cows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cow>> GetCow(int id)
        {
            var cow = await _context.Cow.FindAsync(id);

            if (cow == null)
            {
                return NotFound();
            }

            return cow;
        }

        // PUT: api/Cows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCow(int id, Cow cow)
        {
            if (id != cow.Id)
            {
                return BadRequest();
            }

            _context.Entry(cow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CowExists(id))
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

        // POST: api/Cows
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cow>> PostCow(Cow cow)
        {
            _context.Cow.Add(cow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCow", new { id = cow.Id }, cow);
        }

        // DELETE: api/Cows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCow(int id)
        {
            var cow = await _context.Cow.FindAsync(id);
            if (cow == null)
            {
                return NotFound();
            }

            _context.Cow.Remove(cow);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CowExists(int id)
        {
            return _context.Cow.Any(e => e.Id == id);
        } */
    }
}
