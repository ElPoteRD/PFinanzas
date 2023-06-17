using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface ICategoriaDeIngresoServices
    {
        Task<Result<List<CategoriaDeIngresoResponse>>> Consultar();
    }
}