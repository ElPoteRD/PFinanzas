using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class Ingreso
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public decimal Monto { get; set; }
        public string Descripción { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public Ingreso() { }

        public Ingreso(int usuarioId, int categoriaId, decimal monto, string descripcion, DateTime fecha)
        {
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            Monto = monto;
            Descripción = descripcion;
            Fecha = fecha;
        }
    }
}