using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeGasto
    {
        [Key]
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}