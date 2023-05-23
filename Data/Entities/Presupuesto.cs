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

        public Presupuesto() { }

        public Presupuesto(int usuarioId, int categoriaId, decimal monto, DateTime fecha)
        {
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            Monto = monto;
            Fecha = fecha;
        }
    }
}