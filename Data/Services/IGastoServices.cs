using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface IGastoServices
    {
        Task<Result<List<GastoResponse>>> Consultar(string filtro);
        Task<Result> Crear(GastoRequest request);
        Task<Result> Eliminar(GastoRequest request);
        Task<Result> Modificar(GastoRequest request);
    }
}