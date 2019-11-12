using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos;
using Sistema.Entidades.DataEntidades;
using Sistema.Web.Modelos;

namespace Sistema.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public GruposController(DbContextSistema context)
        {
            _context = context;
        }

        // GET: api/Grupos/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<GruposViewModel>> Listar()
        {
           var grupos = await _context.Grupos.ToListAsync();

           return grupos.Select(g =>
           {
               return new GruposViewModel
               {
                   ID = g.ID,
                   Nombre_Grupo = g.Nombre_Grupo,
                   CreadorID = g.CreadorID
               };
           });
        }

        // POST: api/Grupos/Crear
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] CrearGrupoViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            Grupo grupo = new Grupo
            {
                ID = Guid.NewGuid(),
                Nombre_Grupo = model.Nombre_Grupo,
                CreadorID = model.CreadorID
            };

            _context.Grupos.Add(grupo);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        private bool GrupoExists(Guid id)
        {
            return _context.Grupos.Any(e => e.ID == id);
        }
    }
}