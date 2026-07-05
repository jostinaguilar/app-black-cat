using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class Usuario
    {
        public int Id { get; set; }

        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; } = string.Empty;

        [DisplayName("Usuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Browsable(false)]
        public string Contrasenia { get; set; } = string.Empty;

        [DisplayName("Rol")]
        public string Rol { get; set; } = string.Empty;

        [DisplayName("Correo Electrónico")]
        public string CorreoElectronico { get; set; } = string.Empty;

        [DisplayName("Teléfono")]
        public string Telefono { get; set; } = string.Empty;
    }
}
