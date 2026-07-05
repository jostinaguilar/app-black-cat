using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppBlackCat.Utilidades
{
    internal class Validador
    {
        public static bool EsVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, patronEmail);
        }

        public static bool EsNumero(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;

            return long.TryParse(texto, out _);
        }

        public static bool TieneLongitudExacta(string texto, int longitudRequerida)
        {
            if (texto == null) return false;

            return texto.Length == longitudRequerida;
        }

        public static bool SonTodosIguales(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;

            return texto.Distinct().Count() == 1;
        }

        public static bool EsNombreValido(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+( [a-zA-ZáéíóúÁÉÍÓÚñÑ]+)*$";

            return Regex.IsMatch(texto, patron);
        }

        public static bool EmpiezaCon(string texto, string letra)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;

            return texto.StartsWith(letra, StringComparison.OrdinalIgnoreCase);
        }

        public static bool ContraseniaValida(string contrasenia)
        {
            if (string.IsNullOrWhiteSpace(contrasenia)) return false;

            if (contrasenia.Length < 8) return false;

            if (!Regex.IsMatch(contrasenia, @"[A-Z]")) return false;

            if (!Regex.IsMatch(contrasenia, @"[a-z]")) return false;

            if (!Regex.IsMatch(contrasenia, @"\d")) return false;

            if (!Regex.IsMatch(contrasenia, @"[!@#$%^&*(),.?""':{}|<>]")) return false;

            return true;
        }
    }
}
