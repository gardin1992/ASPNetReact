using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_new_app.Models;

namespace my_new_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public FuncionarioItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/FuncionarioItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuncionarioItem>>> GetFuncionarioItems()
        {
            return await _context.FuncionarioItems.ToListAsync();
        }

        // GET: api/FuncionarioItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuncionarioItem>> GetFuncionarioItem(int id)
        {
            var funcionarioItem = await _context.FuncionarioItems.FindAsync(id);

            if (funcionarioItem == null)
            {
                return NotFound();
            }

            return funcionarioItem;
        }

        // PUT: api/FuncionarioItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuncionarioItem(int id, FuncionarioItem funcionarioItem)
        {
            if (id != funcionarioItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(funcionarioItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionarioItemExists(id))
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

        // POST: api/FuncionarioItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<FuncionarioItem>> PostFuncionarioItem(FuncionarioItem funcionarioItem)
        {
            _context.FuncionarioItems.Add(funcionarioItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuncionarioItem", new { id = funcionarioItem.Id }, funcionarioItem);
        }

        // DELETE: api/FuncionarioItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FuncionarioItem>> DeleteFuncionarioItem(int id)
        {
            var funcionarioItem = await _context.FuncionarioItems.FindAsync(id);
            if (funcionarioItem == null)
            {
                return NotFound();
            }

            _context.FuncionarioItems.Remove(funcionarioItem);
            await _context.SaveChangesAsync();

            return funcionarioItem;
        }

        private bool FuncionarioItemExists(int id)
        {
            return _context.FuncionarioItems.Any(e => e.Id == id);
        }
    }
}
