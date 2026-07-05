using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class Servicio
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; } = string.Empty;

        [DisplayName("Categoría")]
        public string Categoria { get; set; } = string.Empty;

        [DisplayName("Precio")]
        public decimal Precio { get; set; }
    }
}
