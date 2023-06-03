﻿using System.ComponentModel.DataAnnotations;

namespace PFinanzas.Data.Entities
{
    public class IngresoResponse
    {
        
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaDeIngresoResponse? Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Descripción { get; set; } = null!;
        public DateTime Fecha { get; set; }

    }
}