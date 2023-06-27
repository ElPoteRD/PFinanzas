using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Context
{
    public class PFinanzasDbContextSeeder
    {
        public static async Task Inicializar(MyDbContext dbContext)
        {
            if (!dbContext.CategoriaDeIngresos.Any())
            {
                var categorias = new List<CategoriaDeIngreso>() {
                    new CategoriaDeIngreso(){ Categoria = "Sueldo"},
                    new CategoriaDeIngreso(){ Categoria = "Horas Extras"},
                    new CategoriaDeIngreso(){ Categoria = "Negocio"},
                    new CategoriaDeIngreso(){ Categoria = "Otros"}

                };
                dbContext.CategoriaDeIngresos.AddRange(categorias);
                await dbContext.SaveChangesAsync();
            }
            if (!dbContext.CategoriaDeGastos.Any())
            {
                var categorias = new List<CategoriaDeGasto>() {
                    new CategoriaDeGasto(){ Categoria = "Servicios Básicos"},
                    new CategoriaDeGasto(){ Categoria = "Pago Personal"},
                    new CategoriaDeGasto(){ Categoria = "Vehiculo"},
                    new CategoriaDeGasto(){ Categoria = "Otros"}

                };
                dbContext.CategoriaDeGastos.AddRange(categorias);
                await dbContext.SaveChangesAsync();
            }

        }
    }
}
