using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PFinanzas.Data.Request;
using PFinanzas.Data.Response;
namespace PFinanzas.Data.Entities
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public virtual CategoriaDeGasto? Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public static Gasto Crear(GastoRequest Gasto) => new Gasto()
        {
            Id = Gasto.Id,
            UsuarioId = Gasto.UsuarioId,
            CategoriaId = Gasto.CategoriaId,
            Monto = Gasto.Monto,
            Descripcion = Gasto.Descripcion,
            Fecha = Gasto.Fecha,

        };

        public bool Modificar(GastoRequest Gasto)
        {
            var cambio = false;
            if(Monto!=Gasto.Monto)
            {
                Monto = Gasto.Monto;
                cambio = true;
            }

            if (Descripcion != Gasto.Descripcion)
            {
                Descripcion = Gasto.Descripcion;
                cambio = true;
            }

            if (Fecha != Gasto.Fecha)
            {
                Fecha = Gasto.Fecha;
                cambio = true;
            }


            return cambio;
        }

        public GastoResponse ToResponse() => new()
        {
            Id = Id,
            UsuarioId= UsuarioId,
            CategoriaId = CategoriaId,
            Monto = Monto,
            Descripcion=Descripcion,
            Fecha = Fecha
        };
    }
}