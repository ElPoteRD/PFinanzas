using PFinanzas.Data.Entities;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Services
{
    public interface ICategoriaDePresupuestoServices
    {
        Task<Result<List<CategoriaDePresupuestoResponse>>> Consultar();
    }
}