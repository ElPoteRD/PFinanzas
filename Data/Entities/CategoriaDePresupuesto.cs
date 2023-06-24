using System.ComponentModel.DataAnnotations;
using PFinanzas.Data.Response;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDePresupuesto
    {
        [Key]
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;

        public CategoriaDePresupuesto() { 
        
            Presupuestos= new List<Presupuesto>();
        }

        public ICollection<Presupuesto> Presupuestos { get; set; }
        public CategoriaDePresupuestoResponse ToResponse() => new() { Id = Id, Categoria = Categoria };
    }
}