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
        public DbSet<Ahorro> ahorro { get; set; }
        public DbSet<CategoriaDeGasto> categoriaDeGasto { get; set; }
        public DbSet<CategoriaDeIngreso> categoriaDeIngreso { get; set; }
        public DbSet<CategoriaDePresupuesto> categoriaDePresupuesto { get; set; }
        public DbSet<Gasto> gasto { get; set; }
        public DbSet<Ingreso> ingreso { get; set; }
        public DbSet<Presupuesto> presupuesto { get; set; }
        public DbSet<Usuario> usuario { get; set; }

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
