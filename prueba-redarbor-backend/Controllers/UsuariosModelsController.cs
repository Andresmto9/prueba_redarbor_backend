using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_redarbor_backend.Data;
using prueba_redarbor_backend.Models;

namespace prueba_redarbor_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosModelsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public UsuariosModelsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/UsuariosModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuariosModel>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/UsuariosModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuariosModel>> GetUsuariosModel(int id)
        {
            var usuariosModel = await _context.Usuarios.FindAsync(id);

            if (usuariosModel == null)
            {
                return NotFound();
            }

            return usuariosModel;
        }

        // PUT: api/UsuariosModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuariosModel(int id, UsuariosModel usuariosModel)
        {
            if (id != usuariosModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuariosModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuariosModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(usuariosModel);
        }

        // POST: api/UsuariosModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuariosModel>> PostUsuariosModel([FromBody] UsuariosModel usuariosModel)
        {
            _context.Usuarios.Add(usuariosModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuariosModel", new { id = usuariosModel.Id }, usuariosModel);
        }

        // DELETE: api/UsuariosModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuariosModel(int id)
        {
            var usuariosModel = await _context.Usuarios.FindAsync(id);
            if (usuariosModel == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuariosModel);
            await _context.SaveChangesAsync();

            return Ok(usuariosModel);
        }

        // DELETE: api/UsuariosModels
        [HttpDelete]
        public async Task<IActionResult> DeleteUsuariosModels([FromBody] int[] ids)
        {
            if (ids == null || ids.Length == 0)
            {
                throw new ArgumentException("ID's no enviados.");
            }

            var usuariosModel = await _context.Usuarios
                .Where(u => ids.Contains(u.Id))
                .ToListAsync();

            if (usuariosModel.Count == 0)
            {
                throw new KeyNotFoundException("Usuarios no encontrados con los ID's enviados.");
            }

            _context.Usuarios.RemoveRange(usuariosModel);
            await _context.SaveChangesAsync();

            return Ok(usuariosModel);
        }

        private bool UsuariosModelExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
