
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;
using PFinanzas.Data.Response;
using PFinanzas.Data.Request;

namespace PFinanzas.Data.Services
{
    public class GastoServices : IGastoServices
    {
        private readonly IMyDbContext dbContext;

        public GastoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(GastoRequest request)
        {
            try
            {
                var gasto = Gasto.Crear(request);
                dbContext.Gastos.Add(gasto);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Modificar(GastoRequest request)
        {
            try
            {
                var gasto = await dbContext.Gastos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (gasto == null)
                    return new Result { Message = "No Encontrado", Success = false };

                if (gasto.Modificar(request))
                    await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Eliminar(GastoRequest request)
        {
            try
            {
                var gasto = await dbContext.Gastos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (gasto == null)
                    return new Result { Message = "No encontrado", Success = false };

                dbContext.Gastos.Remove(gasto);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result<List<GastoResponse>>> Consultar()
        {
            try
            {
                var gasto = await dbContext.Gastos.Select(c => c.ToResponse()).ToListAsync();

                return new Result<List<GastoResponse>>
                {
                    Message = "Ok",
                    Success = true,
                    Data = gasto
                };
            }
            catch (Exception ex)
            {
                return new Result<List<GastoResponse>> { Message = ex.Message, Success = false };
            }
        }
    }
}
