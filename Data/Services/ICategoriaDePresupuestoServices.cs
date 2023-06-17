using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface ICategoriaDePresupuestoServices
    {
        Task<Result<List<CategoriaDePresupuestoResponse>>> Consultar();
    }
}