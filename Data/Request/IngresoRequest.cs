using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFinanzas.Data.Request
{
    public class IngresoRequest
    {
        
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }= DateTime.Now;

        [NotMapped]
        public decimal Total { get; set; }
    }
}