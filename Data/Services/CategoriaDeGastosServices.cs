
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public class CategoriaDeGastoServices : ICategoriaDeGastoServices
    {
        private readonly IMyDbContext dbContext;

        public CategoriaDeGastoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result<List<CategoriaDeGastoResponse>>> Consultar()
        {
            try
            {
                var categoriaDeGasto = await dbContext.CategoriaDeGastos.Select(c => c.ToResponse()).ToListAsync();
                return new Result<List<CategoriaDeGastoResponse>>()
                {
                    Message = "Ok",
                    Success = true,
                    Data = categoriaDeGasto
                };
            }
            catch (Exception E)
            {
                return new Result<List<CategoriaDeGastoResponse>>
                {
                    Message = E.Message,
                    Success = false
                };
            }
        }

    }

}
