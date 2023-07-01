using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Response
{
    public class CategoriaDeIngresoResponse
    {
        public int Id { get; set; }
        public string? Categoria { get; set; }

    }
}