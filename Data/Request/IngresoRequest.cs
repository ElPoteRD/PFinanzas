using System.ComponentModel.DataAnnotations;

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

    }
}