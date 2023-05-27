using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeGastoResponse
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}