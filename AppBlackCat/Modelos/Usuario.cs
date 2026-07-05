using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Modelos
{
    internal class Usuario
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;

        public string NombreUsuario { get; set; } = string.Empty;

        public string Contrasena { get; set; } = string.Empty;

        public string Rol { get; set; } = string.Empty;

        public string CorreoElectronico { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;
    }
}
