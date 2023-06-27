using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PFinanzas.Data.Context;
using PFinanzas.Data.Request;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Entities
{
    public class Ingreso
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public virtual CategoriaDeIngreso? Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public static Ingreso Crear(IngresoRequest Ingreso) => new Ingreso()
        {
            Id = Ingreso.Id,
            UsuarioId = Ingreso.UsuarioId,
            CategoriaId = Ingreso.CategoriaId,
            Monto = Ingreso.Monto,
            Descripcion = Ingreso.Descripcion,
            Fecha = Ingreso.Fecha,
        };

        public bool Modificar(IngresoRequest Ingreso)
        {
            var cambio = false;
            if (Monto != Ingreso.Monto)
            {
                Monto = Ingreso.Monto;
                cambio = true;
            }

            if (Descripcion != Ingreso.Descripcion)
            {
                Descripcion = Ingreso.Descripcion;
                cambio = true;
            }

            if (Fecha != Ingreso.Fecha)
            {
                Fecha = Ingreso.Fecha;
                cambio = true;
            }

            return cambio;
        }

        public IngresoResponse ToResponse() => new IngresoResponse()
        {
            Id=Id,
            UsuarioId=UsuarioId,
            CategoriaId=CategoriaId,
            Categoria= Categoria?.ToResponse(),
            Monto = Monto,
            Descripción = Descripcion.ToString(),
            Fecha = Fecha,
        };

    }   
}