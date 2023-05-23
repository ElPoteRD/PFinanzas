using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class Ahorro
    {
        [Key]
        public int Id { get; set; }
        public int Usuario;

    }
}
