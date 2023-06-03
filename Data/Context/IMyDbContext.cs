using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Context
{
    public interface IMyDbContext
    {
        DbSet<Ahorro> Ahorros { get; set; }
        DbSet<CategoriaDeGasto> CategoriaDeGastos { get; set; }
        DbSet<CategoriaDeIngreso> CategoriaDeIngresos { get; set; }
        DbSet<CategoriaDePresupuesto> CategoriaDePresupuestos { get; set; }
        DbSet<Gasto> Gastos { get; set; }
        DbSet<Ingreso> Ingresos { get; set; }
        DbSet<Presupuesto> Presupuestos { get; set; }
        DbSet<Usuario> Usuarios { get; set; }

       public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}