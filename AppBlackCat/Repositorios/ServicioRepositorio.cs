using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AppBlackCat.Repositorios
{
    internal class ServicioRepositorio : IServicioRepositorio
    {
        private const string RUTA = "../../../Datos/servicios.json";

        public void GuardarTodos(List<Servicio> servicios)
        {
            string json = JsonSerializer.Serialize(servicios);
            GestorArchivos.Escribir(RUTA, json);
        }

        public List<Servicio> ObtenerTodos()
        {
            string json = GestorArchivos.Leer(RUTA);

            return JsonSerializer.Deserialize<List<Servicio>>(json) ?? [];
        }
    }
}
