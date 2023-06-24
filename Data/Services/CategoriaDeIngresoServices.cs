
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Services
{
    public class CategoriaDeIngresoServices : ICategoriaDeIngresoServices
    {
        private readonly IMyDbContext dbContext;

        public CategoriaDeIngresoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result<List<CategoriaDeIngresoResponse>>> Consultar()
        {
            try
            {
                var categoriaDeIngresos = await dbContext.CategoriaDeIngresos.Select(c => c.ToResponse()).ToListAsync();
                return new Result<List<CategoriaDeIngresoResponse>>()
                {
                    Message = "Ok",
                    Success = true,
                    Data = categoriaDeIngresos
                };
            }
            catch (Exception E)
            {
                return new Result<List<CategoriaDeIngresoResponse>>
                {
                    Message = E.Message,
                    Success = false
                };
            }
        }

    }

}
