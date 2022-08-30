using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASM.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class NguoidungController : ControllerBase
    {
        private readonly DataContext _context;

        public NguoidungController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Nguoidung
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nguoidung>>> GetNguoiDungs()
        {
            return await _context.NguoiDungs.ToListAsync();
        }

        // GET: api/Nguoidung/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nguoidung>> GetNguoidung(int id)
        {
            var nguoidung = await _context.NguoiDungs.FindAsync(id);

            if (nguoidung == null)
            {
                return NotFound();
            }

            return nguoidung;
        }

        // PUT: api/Nguoidung/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNguoidung(int id, Nguoidung nguoidung)
        {
            if (id != nguoidung.NguoiDungId)
            {
                return BadRequest();
            }

            _context.Entry(nguoidung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NguoidungExists(id))
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

        // POST: api/Nguoidung
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nguoidung>> PostNguoidung(Nguoidung nguoidung)
        {
            _context.NguoiDungs.Add(nguoidung);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetNguoidung", new { id = nguoidung.NguoiDungId }, nguoidung);
        }

        // DELETE: api/Nguoidung/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNguoidung(int id)
        {
            var nguoidung = await _context.NguoiDungs.FindAsync(id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            _context.NguoiDungs.Remove(nguoidung);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NguoidungExists(int id)
        {
            return _context.NguoiDungs.Any(e => e.NguoiDungId == id);
        }
    }
}
