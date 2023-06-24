using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Response
{
    public class CategoriaDePresupuestoResponse
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}