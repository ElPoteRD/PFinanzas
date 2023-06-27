using System.ComponentModel.DataAnnotations;
using PFinanzas.Data.Request;

namespace PFinanzas.Data.Response
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;

        public UsuarioRequest ToRequest()
        {
            return new UsuarioRequest
            {
                Id = Id,
                Nombre= Nombre,
                Apellido= Apellido,
                Correo= Correo
            };
        }
    }

    


}
