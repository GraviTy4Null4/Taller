using Microsoft.EntityFrameworkCore;
using Taller_Reparacion.Domain;

namespace Taller_Reparacion.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<EstadoOrden> EstadoOrdenes  { get; set; }
        public DbSet<HistorialEstado> HistorialEstados { get; set; }
        public DbSet<OrdenServicio> OrdenServicios { get; set; }
        public DbSet<RefaccionUsada> RefaccionesUsadas  { get; set; }
        public DbSet<TipoFalla> TipoFallas  { get; set; }
        public DbSet<Usuario> Usuarios  { get; set; }
    }
}
