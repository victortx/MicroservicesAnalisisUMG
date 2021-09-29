using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MicroservicesAnalisisUMG.Data;
using MicroservicesAnalisisUMG.Models;
using Microsoft.AspNetCore.Authorization;

namespace MicroservicesAnalisisUMG.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PositsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PositsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Posits
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Posit.ToListAsync());
        }

        [HttpGet("{id}")]
        // GET: Posits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posit = await _context.Posit
                .FirstOrDefaultAsync(m => m.PositId == id);
            if (posit == null)
            {
                return NotFound();
            }

            return Ok(posit);
        }

        // POST: Posits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Posit posit)
        {
            if (ModelState.IsValid)
            {
                posit.FechaCreacion = DateTime.Now;
                _context.Add(posit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Ok(posit);
        }

        // POST: Posits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Posit posit)
        {
            if (id != posit.PositId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositExists(posit.PositId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Ok(posit);
        }

        // POST: Posits/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posit = await _context.Posit.FindAsync(id);
            _context.Posit.Remove(posit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool PositExists(int id)
        {
            return _context.Posit.Any(e => e.PositId == id);
        }
    }
}
