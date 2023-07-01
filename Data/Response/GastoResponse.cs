using PFinanzas.Data.Request;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFinanzas.Data.Response
{
    public class GastoResponse
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaDeGastoResponse? Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }


        public GastoRequest ToRequest()
        {
            return new GastoRequest
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