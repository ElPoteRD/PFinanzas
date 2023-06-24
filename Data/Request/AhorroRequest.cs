using System.ComponentModel.DataAnnotations;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Request
{
    public class AhorroRequest
    {
        public int Id { get; set; }
        public int Usuario;
    }
}
