
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public class PresupuestoServices : IPresupuestoServices
    {
        private readonly IMyDbContext dbContext;

        public PresupuestoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(PresupuestoRequest request)
        {
            try
            {
                var Presupuesto = Entities.Presupuesto.Crear(request);
                dbContext.Presupuestos.Add(Presupuesto);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Modificar(PresupuestoRequest request)
        {
            try
            {
                var Presupuesto = await dbContext.Presupuestos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (Presupuesto == null)
                    return new Result { Message = "No Encontrado", Success = false };

                if (Presupuesto.Modificar(request))
                    await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Eliminar(PresupuestoRequest request)
        {
            try
            {
                var presupuesto = await dbContext.Presupuestos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (presupuesto == null)
                    return new Result { Message = "No encontrado", Success = false };

                dbContext.Presupuestos.Remove(presupuesto);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result<List<PresupuestoResponse>>> Consultar(string filtro)
        {
            try
            {
                var Presupuesto = await dbContext.Presupuestos.Where(c => (c.Fecha + " " + c.Monto + " " + c.CategoriaId).ToLower().Contains(filtro.ToLower())).Select(c => c.ToResponse()).ToListAsync();

                return new Result<List<PresupuestoResponse>>
                {
                    Message = "Ok",
                    Success = true,
                    Data = Presupuesto
                };
            }
            catch (Exception ex)
            {
                return new Result<List<PresupuestoResponse>> { Message = ex.Message, Success = false };
            }
        }

    }

    //public class Result
    //{
    //    public bool Success { get; set; }
    //    public string? Message { get; set; }

    //}

    //public class Result<T>
    //{
    //    public bool Success { get; set; }
    //    public string? Message { get; set; }
    //    public T? Data { get; set; }

    //}

}
