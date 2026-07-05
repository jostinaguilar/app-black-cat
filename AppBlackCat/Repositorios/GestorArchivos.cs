using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Repositorios
{
    internal class GestorArchivos
    {
        public static void Escribir(string ruta, string json)
        {
            StreamWriter escritor = new StreamWriter(ruta);
            escritor.Write(json);
            escritor.Close();
        }

        public static string Leer(string ruta)
        {
            if (!File.Exists(ruta))
            {
                Escribir(ruta, "[]");
                return "[]";
            }

            StreamReader lector = new StreamReader(ruta);
            string json = lector.ReadToEnd();
            lector.Close();

            return json;
        }
    }
}
