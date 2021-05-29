using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaS.Shared.Modelo;

namespace PruebaS.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>().HasKey(x => x.Id);
            modelBuilder.Entity<Producto>().HasKey(x => x.Id);
            modelBuilder.Entity<Categoria>().HasKey(x => x.Id);
            modelBuilder.Entity<HistoriaProducto>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
        //Se crea la tabla en la bd basado en el modelo persona
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<HistoriaProducto> HistoriaProducto { get; set; }
    }
}
