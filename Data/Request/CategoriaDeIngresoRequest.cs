using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class CategoriaDeIngresoRequest
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = null!;
    }
}