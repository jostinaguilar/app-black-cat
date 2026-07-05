using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AppBlackCat.Repositorios
{
    internal class ClienteRepositorio : IClienteRepositorio
    {
        private const string RUTA = "../../../Datos/clientes.json";

        public List<Cliente> ObtenerTodos()
        {
            string json = GestorArchivos.Leer(RUTA);

            return JsonSerializer.Deserialize<List<Cliente>>(json) ?? [];
        }

        public void GuardarTodos(List<Cliente> clientes)
        {
            string json = JsonSerializer.Serialize(clientes);
            GestorArchivos.Escribir(RUTA, json);
        }
    }
}
