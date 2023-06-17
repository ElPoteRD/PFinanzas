using PFinanzas.Data.Entities;

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