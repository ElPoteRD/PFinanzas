﻿using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class PresupuestoRequest
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public PresupuestoRequest() { }

        public PresupuestoRequest(int usuarioId, int categoriaId, decimal monto, DateTime fecha)
        {
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            Monto = monto;
            Fecha = fecha;
        }
    }
}