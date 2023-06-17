using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface IIngresoServices
    {
        Task<Result<List<IngresoResponse>>> Consultar(string filtro);
        Task<Result> Crear(IngresoRequest request);
        Task<Result> Eliminar(IngresoRequest request);
        Task<Result> Modificar(IngresoRequest request);
    }
}