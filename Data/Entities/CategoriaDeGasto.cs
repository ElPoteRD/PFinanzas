using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeGasto
    {
        public CategoriaDeGasto() { 
            Gastos= new List<Gasto>();

        }
        [Key]
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;

        public virtual ICollection<Gasto> Gastos { get; set; }
        public CategoriaDeGastoResponse ToResponse() => new() { Id = Id, Categoria = Categoria };
    }
}