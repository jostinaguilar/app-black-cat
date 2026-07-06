using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AppBlackCat.Repositorios
{
    internal class CotizacionRepositorio: ICotizacionRepositorio
    {
        private const string RUTA = "../../../Datos/cotizaciones.json";

        public void GuardarTodos(List<Cotizacion> cotizaciones)
        {
            string json = JsonSerializer.Serialize(cotizaciones);
            GestorArchivos.Escribir(RUTA, json);
        }

        public List<Cotizacion> ObtenerTodos()
        {
            string json = GestorArchivos.Leer(RUTA);

            return JsonSerializer.Deserialize<List<Cotizacion>>(json) ?? [];
        }
    }
}
