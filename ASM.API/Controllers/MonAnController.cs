using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MonAnController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMonAnSvc _monAnSvc;

        public MonAnController(DataContext context, IMonAnSvc monAnSvc)
        {
            _context = context;
            this._monAnSvc = monAnSvc;
        }

        // GET: api/MonAn
        [HttpGet]
        public ActionResult<IEnumerable<MonAn>> GetMonAns()
        {
            return  _monAnSvc.GetMonAnAll();
        }

        // GET: api/MonAn/5
        [HttpGet("{id}")]
        public  ActionResult<MonAn> GetMonAn(int id)
        {
            
            return  _monAnSvc.GetMonAn(id);
        }

        // PUT: api/MonAn/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonAn(int id, MonAn monAn)
        {
            if (id != monAn.Id)
            {
                return BadRequest();
            }


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //var monan = await _monAnSvc.GetMonAn(id);
            //if (monan == null) return NotFound($"{id} is not found");


            try
            {
                await _monAnSvc.EditMonAn(id, monAn);
                //await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonAnExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok( _monAnSvc.GetMonAn(id));
        }

        // POST: api/MonAn
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MonAn>> PostMonAn(MonAn monAn)
        {
            await _monAnSvc.AddMonAn(monAn);

            return CreatedAtAction("GetMonAn", new { id = monAn.Id }, monAn);
        }

        // DELETE: api/MonAn/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonAn(int id)
        {
            var monAn = await _context.MonAns.FindAsync(id);
            if (monAn == null)
            {
                return NotFound();
            }

            _context.MonAns.Remove(monAn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MonAnExists(int id)
        {
            return _context.MonAns.Any(e => e.Id == id);
        }
    }
}
