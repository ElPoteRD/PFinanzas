using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface ICategoriaDeGastoServices
    {
        Task<Result<List<CategoriaDeGastoResponse>>> Consultar();
    }
}