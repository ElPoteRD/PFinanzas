using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PFinanzas.Data.Request;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Entities
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public virtual CategoriaDePresupuesto? Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public static Presupuesto Crear(PresupuestoRequest Presupuesto) => new Presupuesto()
        {
            Id = Presupuesto.Id,
            UsuarioId = Presupuesto.UsuarioId,
            CategoriaId = Presupuesto.CategoriaId,
            Monto = Presupuesto.Monto,
            Fecha = Presupuesto.Fecha,
        };

        public bool Modificar(PresupuestoRequest Presupuesto)
        {
            var cambio = false;
            if (UsuarioId != Presupuesto.UsuarioId)
            {
                UsuarioId = Presupuesto.UsuarioId;
                cambio = true;
            }

            if (CategoriaId != Presupuesto.CategoriaId)
            {
                CategoriaId = Presupuesto.CategoriaId;
                cambio = true;
            }

            if (Monto != Presupuesto.Monto)
            {                
                Monto = Presupuesto.Monto;
                cambio = true;
            }

            if (Fecha != Presupuesto.Fecha)
            {
                Fecha = Presupuesto.Fecha;
                cambio = true;
            }

            return cambio;


        }


        public PresupuestoResponse ToResponse() => new PresupuestoResponse()
        {
            Id = Id,
            UsuarioId = UsuarioId,
            CategoriaId = CategoriaId,
            Monto = Monto,
            Fecha = Fecha,
        };

    }
}