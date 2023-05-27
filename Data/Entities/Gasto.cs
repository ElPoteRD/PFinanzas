using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public decimal Monto { get; set; }
        public string Descripción { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public static Gasto Crear(GastoRequest Gasto) => new Gasto()
        {
            Id = Gasto.Id,
            UsuarioId = Gasto.UsuarioId,
            CategoriaId = Gasto.CategoriaId,
            Monto = Gasto.Monto,
            Descripción = Gasto.Descripción,
            Fecha = Gasto.Fecha,

        };

        public bool Modificar(GastoRequest Gasto)
        {
            var cambio = false;
            if(Monto!=Gasto.Monto)
            {
                Monto = Gasto.Monto;
                cambio = true;
            }

            if (Descripción != Gasto.Descripción)
            {
                Descripción = Gasto.Descripción;
                cambio = true;
            }

            if (Fecha != Gasto.Fecha)
            {
                Fecha = Gasto.Fecha;
                cambio = true;
            }


            return cambio;
        }

        public GastoResponse ToResponse(GastoRequest Gasto) => new GastoResponse()
        {
            Id = Gasto.Id,
            UsuarioId= Gasto.UsuarioId,
            CategoriaId = Gasto.CategoriaId,
            Monto = Monto,
            Descripción=Descripción,
            Fecha = Fecha,
        };
    }
}