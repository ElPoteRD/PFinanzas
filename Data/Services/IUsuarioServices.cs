using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public interface IUsuarioServices
    {
        Task<Result<List<UsuarioResponse>>> Consultar(string filtro);
        Task<Result> Crear(UsuarioRequest request);
        Task<Result> Eliminar(UsuarioRequest request);
        Task<Result> Modificar(UsuarioRequest request);
    }
}