using PFinanzas.Data.Entities;
using PFinanzas.Data.Response;
using PFinanzas.Data.Request;
namespace PFinanzas.Data.Services
{
    public interface IPresupuestoServices
    {
        Task<Result<List<PresupuestoResponse>>> Consultar(string filtro);
        Task<Result> Crear(PresupuestoRequest request);
        Task<Result> Eliminar(PresupuestoRequest request);
        Task<Result> Modificar(PresupuestoRequest request);
    }
}