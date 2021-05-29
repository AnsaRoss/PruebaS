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
    public class ProductoController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProductoController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            var lista = context.Producto.FromSqlRaw("EXECUTE dbo.sp_ConsultaProductos").ToList();
            return lista;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            return await context.Producto
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Producto producto)
        {
            var dato = new Producto()
            {
                Descripcion = producto.Descripcion,
                Marca = producto.Marca,
                Medida = producto.Medida,
                Cantidad = producto.Cantidad,
                PrecioUnitario = producto.PrecioUnitario,
                CategoriaId = producto.CategoriaId,
                ProveedorId = producto.ProveedorId
            };
            context.Producto.Add(dato);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Producto producto)
        {
            Producto dato = context.Producto.Where(x => x.Id == producto.Id).SingleOrDefault();
            dato.Descripcion = producto.Descripcion;
            dato.Marca = producto.Marca;
            dato.Medida = producto.Medida;
            dato.Cantidad = producto.Cantidad;
            dato.PrecioUnitario = producto.PrecioUnitario;
            dato.CategoriaId = producto.CategoriaId;
            dato.ProveedorId = producto.ProveedorId;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Producto.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            Producto dato = context.Producto.Where(x => x.Id == id).SingleOrDefault();
            context.Producto.Remove(dato);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
