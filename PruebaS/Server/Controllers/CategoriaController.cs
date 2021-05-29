using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaS.Shared.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CategoriaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            //return await context.Categoria.ToListAsync();
            var lista = context.Categoria.FromSqlRaw("EXECUTE dbo.sp_ConsultaCategoria").ToList();
            return lista;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            //var result = context.Categoria.FromSqlRaw($"EXECUTE dbo.sp_ConsultaCategoriaId @id={id}");
            //return Ok(result);
            return await context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Categoria categoria)
        {
            var categoriaData = new Categoria()
            {
                Nombre = categoria.Nombre
            };
            context.Categoria.Add(categoriaData);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Categoria categoria)
        {
            //context.Attach(categoria).State = EntityState.Modified;
            //await context.SaveChangesAsync();
            //return NoContent();

            Categoria categoriaData = context.Categoria.Where(x => x.Id == categoria.Id).SingleOrDefault();
            categoriaData.Nombre = categoria.Nombre;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            //var existe = await context.Categoria.AnyAsync(x => x.Id == id);
            //if (!existe) { return NotFound(); }
            //context.Remove(new Categoria { Id = id });
            //await context.SaveChangesAsync();
            //return NoContent();
            Categoria categoriaData = context.Categoria.Where(x => x.Id == id).SingleOrDefault();
            context.Categoria.Remove(categoriaData);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
