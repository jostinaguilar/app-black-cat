using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class CotizacionDetalle
    {
        public int Id { get; set; }

        public int CotizacionId { get; set; }

        public int ServicioId { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get { return Cantidad * PrecioUnitario; } }
    }
}
