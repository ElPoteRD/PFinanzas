using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Context
{
    public class MyDbContext : DbContext, IMyDbContext
    {
        private readonly IConfiguration config;

        public MyDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Ahorro> Ahorros { get; set; }
        public DbSet<CategoriaDeGasto> CategoriaDeGastos { get; set; }
        public DbSet<CategoriaDeIngreso> CategoriaDeIngresos { get; set; }
        public DbSet<CategoriaDePresupuesto> CategoriaDePresupuestos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: config.GetConnectionString(name: "MSSQL"));
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
