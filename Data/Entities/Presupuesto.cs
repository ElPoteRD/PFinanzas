using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
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

    }
}