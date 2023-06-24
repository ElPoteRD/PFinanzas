using PFinanzas.Data.Entities;
using PFinanzas.Data.Request;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Services
{
    public interface ICategoriaDeIngresoServices
    {
        Task<Result<List<CategoriaDeIngresoResponse>>> Consultar();
    }
}