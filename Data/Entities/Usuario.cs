using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PFinanzas.Data.Request;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;

        public static Usuario Crear(UsuarioRequest Usuario) => new Usuario()
        {
            Id= Usuario.Id,
            Nombre = Usuario.Nombre,
            Apellido = Usuario.Apellido,
            Correo = Usuario.Correo,
            Contraseña = Usuario.Contraseña,
        };

        public bool Modificar(UsuarioRequest Usuario)
        {
            var cambio = false;
            if (Nombre != Usuario.Nombre)
            {
                Nombre = Usuario.Nombre;
                cambio = true;
            }
            if (Apellido != Usuario.Apellido)
            {
                Apellido = Usuario.Apellido;
                cambio = true;
            }
            if (Correo != Usuario.Correo)
            {
                Correo = Usuario.Correo;
                cambio = true;
            }
            if (Contraseña != Usuario.Contraseña)
            {
                Contraseña = Usuario.Contraseña;
                cambio = true;
            }
            return cambio;
        }

        public UsuarioResponse ToResponse() => new UsuarioResponse()
        {
            Id=Id,
            Nombre = Nombre,
            Apellido = Apellido,
            Correo = Correo
        };
    }

}
