using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Context
{
    public interface IMyDbContext
    {
        DbSet<Ahorro> ahorro { get; set; }
        DbSet<CategoriaDeGasto> categoriaDeGasto { get; set; }
        DbSet<CategoriaDeIngreso> categoriaDeIngreso { get; set; }
        DbSet<CategoriaDePresupuesto> categoriaDePresupuesto { get; set; }
        DbSet<Gasto> gasto { get; set; }
        DbSet<Ingreso> ingreso { get; set; }
        DbSet<Presupuesto> presupuesto { get; set; }
        DbSet<UsuarioRequest> usuario { get; set; }

       public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}