using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Servicios
{
    internal class UsuarioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void RegistrarUsuario(Usuario nuevoUsuario)
        {
            ValidarUsuario(nuevoUsuario);

            var usuarios = _usuarioRepositorio.ObtenerTodos();

            if (usuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario ya está en uso.");
            }

            int nuevoId = usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;

            usuarios.Add(nuevoUsuario);
            _usuarioRepositorio.GuardarTodos(usuarios);
        }

        public void ValidarUsuario(Usuario usuario)
        {
            //TODO: Implementar validaciones de usuario (por ejemplo, verificar que los campos no estén vacíos, que el correo electrónico tenga un formato válido, etc.)
        }
    }
}
