using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeIngreso
    {
        public CategoriaDeIngreso()
        {
            Ingresos = new List<Ingreso>();
        }
        [Key]
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;

        public virtual ICollection<Ingreso> Ingresos { get; set; }

        public CategoriaDeIngresoResponse ToResponse() => new() {Id = Id, Categoria = Categoria};
    }
}