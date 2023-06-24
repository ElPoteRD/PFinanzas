using PFinanzas.Data.Entities;
using PFinanzas.Data.Response;
using PFinanzas.Data.Request;
namespace PFinanzas.Data.Services
{
    public interface IUsuarioServices
    {
        Task<Result<List<UsuarioResponse>>> Consultar();
        Task<Result> Crear(UsuarioRequest request);
        Task<Result> Eliminar(UsuarioRequest request);
        Task<Result> Modificar(UsuarioRequest request);
    }
}