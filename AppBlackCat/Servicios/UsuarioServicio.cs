using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using AppBlackCat.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Servicios
{
    internal class UsuarioServicio
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio)
        {
            _repositorio = usuarioRepositorio;
        }

        public void RegistrarUsuario(Usuario nuevoUsuario)
        {
            ValidarUsuario(nuevoUsuario);

            var usuarios = _repositorio.ObtenerTodos();

            if (usuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario ya está en uso.");
            }

            nuevoUsuario.Id = usuarios.Count > 0 ? usuarios.Max(u => u.Id) + 1 : 1;

            usuarios.Add(nuevoUsuario);
            _repositorio.GuardarTodos(usuarios);
        }

        public List<Usuario> ObtenerTodos()
        {
            var usuarios = _repositorio.ObtenerTodos();
            return usuarios;
        }


        public Usuario ObtenerPorId(int id)
        {
            var usuarios = _repositorio.ObtenerTodos();
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
            {
                throw new Exception("No se encontró el usuario.");
            }

            return usuario;
        }

        public void Actualizar(Usuario usuarioActualizado)
        {
            var usuarios = _repositorio.ObtenerTodos();

            var index = usuarios.FindIndex(c => c.Id == usuarioActualizado.Id);

            if (index == -1)
            {
                throw new Exception("No se encontro el cliente a actualizar.");
            }

            ValidarUsuario(usuarioActualizado);

            usuarios[index] = usuarioActualizado;

            _repositorio.GuardarTodos(usuarios);
        }

        public void Eliminar(int id)
        {
            var usuarios = _repositorio.ObtenerTodos();
            var index = usuarios.FindIndex(c => c.Id == id);

            if (index == -1)
            {
                throw new Exception("No se encontró el usuario a eliminar.");
            }

            usuarios.RemoveAt(index);
            _repositorio.GuardarTodos(usuarios);
        }

        public List<Usuario> Buscar(string texto)
        {
            var usuarios = _repositorio.ObtenerTodos();
            var usuariosFiltrados = usuarios.Where(c =>
                c.NombreUsuario.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                c.NombreCompleto.Contains(texto, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (usuariosFiltrados.Count == 0)
            {
                throw new Exception("No se encontraron clientes que coincidan con la búsqueda.");
            }

            return usuariosFiltrados;
        }

        public void ValidarUsuario(Usuario usuario)
        {
            if (Validador.EsVacio(usuario.NombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");

            if (Validador.EsVacio(usuario.NombreCompleto))
                throw new ArgumentException("El nombre deL usuario no puede estar vacío.");

            if (!Validador.EsNombreValido(usuario.NombreCompleto))
                throw new ArgumentException("El nombre solo debe contener letras, sin caracteres especiales ni espacios múltiples.");

            if (Validador.EsVacio(usuario.Rol))
                throw new ArgumentException("Seleccione un rol para el usuario.");

            if (Validador.EsVacio(usuario.Contrasenia))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            if (!Validador.ContraseniaValida(usuario.Contrasenia))
                throw new ArgumentException("La contraseña debe tener al menos 8 caracteres, incluyendo una letra mayúscula, una letra minúscula y un número.");

            if (!Validador.EsVacio(usuario.Telefono))
            {
                if (!Validador.EsNumero(usuario.Telefono))
                    throw new ArgumentException("El teléfono debe contener solo dígitos numéricos.");

                if (!Validador.TieneLongitudExacta(usuario.Telefono, 9))
                    throw new ArgumentException("El teléfono debe tener exactamente 9 dígitos.");

                if (!Validador.EmpiezaCon(usuario.Telefono, "9"))
                    throw new ArgumentException("El teléfono debe empezar con el número 9.");
            }

            if (!Validador.EsVacio(usuario.CorreoElectronico) && !Validador.EsEmailValido(usuario.CorreoElectronico))
                throw new ArgumentException("El formato del correo electrónico no es válido.");
        }
    }
}
