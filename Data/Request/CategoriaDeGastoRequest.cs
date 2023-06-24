using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Request
{
    public class CategoriaDeGastoRequest
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}