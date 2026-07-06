using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class Cotizacion
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int UsuarioId { get; set; }

        public DateOnly FechaEmision { get; set; }

        public DateOnly FechaVigencia { get; set; }

        public List<CotizacionDetalle> Detalles { get; set; } = new List<CotizacionDetalle>();

        public decimal Total { get { return Detalles.Sum(d => d.Subtotal); } }

        public EstadoEnum Estado { get; set; } = EstadoEnum.Pendiente;

        public enum EstadoEnum
        {
            Pendiente,
            Aprobada,
            Rechazada
        }
    }
}
