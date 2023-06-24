using System.ComponentModel.DataAnnotations;
using PFinanzas.Data.Request;
namespace PFinanzas.Data.Response
{
    public class CategoriaDeGastoResponse
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}