using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class PresupuestoResponse
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaDePresupuestoResponse? Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

    }
}