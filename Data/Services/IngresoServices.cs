
using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public class IngresoServices : IIngresoServices
    {
        private readonly IMyDbContext dbContext;

        public IngresoServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(IngresoRequest request)
        {
            try
            {
                var ingreso = Entities.Ingreso.Crear(request);
                dbContext.Ingresos.Add(ingreso);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Modificar(IngresoRequest request)
        {
            try
            {
                var ingreso = await dbContext.Ingresos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (ingreso == null)
                    return new Result { Message = "No Encontrado", Success = false };

                if (ingreso.Modificar(request))
                    await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Eliminar(IngresoRequest request)
        {
            try
            {
                var ingreso = await dbContext.Ingresos.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (ingreso == null)
                    return new Result { Message = "No encontrado", Success = false };

                dbContext.Ingresos.Remove(ingreso);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result<List<IngresoResponse>>> Consultar(string filtro)
        {
            try
            {
                var ingreso = await dbContext.Ingresos.Where(c => (c.Fecha + " " + c.Descripción + " " + c.Monto + " " + c.CategoriaId).ToLower().Contains(filtro.ToLower())).Select(c => c.ToResponse()).ToListAsync();

                return new Result<List<IngresoResponse>>
                {
                    Message = "Ok",
                    Success = true,
                    Data = ingreso
                };
            }
            catch (Exception ex)
            {
                return new Result<List<IngresoResponse>> { Message = ex.Message, Success = false };
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
