using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AppBlackCat.Repositorios
{
    internal class UsuarioRepositorio : IUsuarioRepositorio
    {
        private const string RUTA = "../../../Datos/usuarios.json";
        public List<Usuario> ObtenerTodos()
        {
            string json = GestorArchivos.Leer(RUTA);
            return JsonSerializer.Deserialize<List<Usuario>>(json) ?? [];
        }
        public void GuardarTodos(List<Usuario> usuarios)
        {
            string json = JsonSerializer.Serialize(usuarios);
            GestorArchivos.Escribir(RUTA, json);
        }
    }
}
