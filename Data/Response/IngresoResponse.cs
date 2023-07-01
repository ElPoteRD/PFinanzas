using PFinanzas.Data.Request;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PFinanzas.Data.Response
{
    public class IngresoResponse
    {
        
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaDeIngresoResponse? Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public IngresoRequest ToRequest()
        {
            return new IngresoRequest
            {
                Id = Id,
                UsuarioId = UsuarioId,
                CategoriaId = CategoriaId,
                Monto = Monto,
                Descripcion = Descripcion,
                Fecha = Fecha,
            };
        }
    }
}