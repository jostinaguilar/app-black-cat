using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class Cliente
    {
        public int Id { get; set; }

        [DisplayName("Número de Documento")]
        public string NumeroDocumento { get; set; } = string.Empty;

        [DisplayName("Tipo de Documento")]
        public string TipoDocumento { get; set; } = string.Empty;

        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [DisplayName("Tipo de Cliente")]
        public string TipoCliente { get; set; } = string.Empty;

        [DisplayName("Teléfono")]
        public string Telefono { get; set; } = string.Empty;

        [DisplayName("Correo Electrónico")]
        public string CorreoElectronico { get; set; } = string.Empty;

        [DisplayName("Dirección")]
        public string Direccion { get; set; } = string.Empty;
    }
}
