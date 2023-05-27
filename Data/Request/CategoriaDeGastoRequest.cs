using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeGastoRequest
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}