
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Response;
namespace PFinanzas.Data.Services
{
    public class CategoriaDePresupuestoServices : ICategoriaDePresupuestoServices
    {
        private readonly IMyDbContext dbContext;

        public CategoriaDePresupuestoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result<List<CategoriaDePresupuestoResponse>>> Consultar()
        {
            try
            {
                var categoriaDePresupuesto = await dbContext.CategoriaDePresupuestos.Select(c => c.ToResponse()).ToListAsync();
                return new Result<List<CategoriaDePresupuestoResponse>>()
                {
                    Message = "Ok",
                    Success = true,
                    Data = categoriaDePresupuesto
                };
            }
            catch (Exception E)
            {
                return new Result<List<CategoriaDePresupuestoResponse>>
                {
                    Message = E.Message,
                    Success = false
                };
            }
        }

    }

}
