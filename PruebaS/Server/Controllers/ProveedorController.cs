using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    public class ProveedorController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProveedorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Proveedor>>> Get()
        {
            var lista = context.Proveedor.FromSqlRaw("EXECUTE dbo.sp_ConsultaProveedores").ToList();
            return lista;
            //return await context.Proveedor.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Proveedor>> Get(int id)
        {


            //var param = new SqlParameter
            //{
            //    ParameterName = id,
            //    SqlDbType = System.Data.SqlDbType.Int,
            //    Direction = System.Data.ParameterDirection.Input
            //};

            var result = context.Proveedor.FromSqlRaw($"EXECUTE dbo.sp_ConsultaCategoriaId @id={id}");
            return Ok(result);

            //var Usuarios = context.Database.ExecuteSqlRaw("EXECUTE dbo.sp_ConsultaCategoriaId @p0", id);
            //return Ok(Usuarios);
            //return await context.Proveedor.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proveedor proveedor)
        {
            var dato = new Proveedor()
            {
                Nombre = proveedor.Nombre,
                Ruc = proveedor.Ruc,
                Direccion=proveedor.Direccion,
                Telefono=proveedor.Telefono,
                Correo=proveedor.Correo
            };
            context.Proveedor.Add(dato);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Proveedor proveedor)
        {
            Proveedor dato = context.Proveedor.Where(x => x.Id == proveedor.Id).SingleOrDefault();
            dato.Nombre = proveedor.Nombre;
            dato.Ruc = proveedor.Ruc;
            dato.Telefono = proveedor.Telefono;
            dato.Direccion = proveedor.Direccion;
            dato.Correo = proveedor.Correo;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Proveedor.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            Proveedor dato = context.Proveedor.Where(x => x.Id == id).SingleOrDefault();
            context.Proveedor.Remove(dato);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}