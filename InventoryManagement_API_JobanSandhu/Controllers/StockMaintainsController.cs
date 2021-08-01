using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryManagement_API_JobanSandhu.Data;
using InventoryManagement_API_JobanSandhu.Models;

namespace InventoryManagement_API_JobanSandhu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockMaintainsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockMaintainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StockMaintains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockMaintain>>> GetStockMaintains()
        {
            return await _context.StockMaintains.ToListAsync();
        }

        // GET: api/StockMaintains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockMaintain>> GetStockMaintain(int id)
        {
            var stockMaintain = await _context.StockMaintains.FindAsync(id);

            if (stockMaintain == null)
            {
                return NotFound();
            }

            return stockMaintain;
        }

        // PUT: api/StockMaintains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockMaintain(int id, StockMaintain stockMaintain)
        {
            if (id != stockMaintain.ID)
            {
                return BadRequest();
            }

            _context.Entry(stockMaintain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockMaintainExists(id))
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

        // POST: api/StockMaintains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StockMaintain>> PostStockMaintain(StockMaintain stockMaintain)
        {
            _context.StockMaintains.Add(stockMaintain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStockMaintain", new { id = stockMaintain.ID }, stockMaintain);
        }

        // DELETE: api/StockMaintains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StockMaintain>> DeleteStockMaintain(int id)
        {
            var stockMaintain = await _context.StockMaintains.FindAsync(id);
            if (stockMaintain == null)
            {
                return NotFound();
            }

            _context.StockMaintains.Remove(stockMaintain);
            await _context.SaveChangesAsync();

            return stockMaintain;
        }

        private bool StockMaintainExists(int id)
        {
            return _context.StockMaintains.Any(e => e.ID == id);
        }
    }
}
