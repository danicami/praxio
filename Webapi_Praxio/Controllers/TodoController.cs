using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapi_Praxio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webapi_Praxio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly NotaFiscal _context;

        public TodoController(NotaFiscal context)
        {
            _context = context;

            if (_context.Clientes.Count() == 0)
            {
                
                _context.Clientes.Add(new Cliente { Nome = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        // GET: api/Todo/5
        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var todoCliente = await _context.Clientes.FindAsync(id);

            if (todoCliente == null)
            {
                return NotFound();
            }

            return todoCliente;
        }


        // POST: api/Todo
        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostTodoItem(Cliente todoCliente)
        {
            _context.Clientes.Add(todoCliente);
            await _context.SaveChangesAsync();

            //           return CreatedAtAction("GetTodoCliente", new { id = todoCliente.ID }, todoCliente);
            return NoContent();
        }

        // PUT: api/Todo/5
        [Authorize("Bearer")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Cliente todoCliente)
        {
            if (id != todoCliente.ID)
            {
                return BadRequest();
            }

            _context.Entry(todoCliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Todo/5
        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cliente>> DeleteCliente(int id)
        {
            var todoCliente = await _context.Clientes.FindAsync(id);
            if (todoCliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(todoCliente);
            await _context.SaveChangesAsync();

            //          return todoCliente;
            return NoContent();  
        }


    }
}
