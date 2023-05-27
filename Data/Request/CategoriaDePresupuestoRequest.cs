using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDePresupuestoRequest
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}