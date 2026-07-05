using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using AppBlackCat.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Servicios
{
    internal class ClienteServicio
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteServicio(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void RegistrarCliente(Cliente nuevoCliente)
        {
            ValidarCliente(nuevoCliente);

            var clientes = _repositorio.ObtenerTodos();

            if (clientes.Any(c => c.NumeroDocumento == nuevoCliente.NumeroDocumento))
            {
                throw new ArgumentException("Ya existe un cliente registrado con este número de documento.");
            }

            nuevoCliente.Id = clientes.Count > 0 ? clientes.Max(c => c.Id) + 1 : 1;

            clientes.Add(nuevoCliente);
            _repositorio.GuardarTodos(clientes);
        }

        public List<Cliente> ObtenerTodos()
        {
            var clientes = _repositorio.ObtenerTodos();
            return clientes;
        }

        public Cliente ObtenerPorId(int id)
        {
            var clientes = _repositorio.ObtenerTodos();

            var cliente = clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                throw new Exception("No se encontró el cliente.");
            }

            return cliente;
        }

        public void ActualizarCliente(Cliente clienteActualizado)
        {
            var clientes = _repositorio.ObtenerTodos();

            var index = clientes.FindIndex(c => c.Id == clienteActualizado.Id);

            if (index == -1)
            {
                throw new Exception("No se encontro el cliente a actualizar.");
            }

            ValidarCliente(clienteActualizado);

            clientes[index] = clienteActualizado;

            _repositorio.GuardarTodos(clientes);
        }

        public void EliminarCliente(int id)
        {
            var clientes = _repositorio.ObtenerTodos();

            var index = clientes.FindIndex(c => c.Id == id);

            if (index == -1)
            {
                throw new Exception("No se encontró el cliente a eliminar.");
            }

            clientes.RemoveAt(index);

            _repositorio.GuardarTodos(clientes);
        }

        public List<Cliente> BuscarClientes(string texto)
        {
            var clientes = _repositorio.ObtenerTodos();
            var clientesFiltrados = clientes.Where(c =>
                c.NombreCompleto.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                c.NumeroDocumento.Contains(texto, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (clientesFiltrados.Count == 0)
            {
                throw new Exception("No se encontraron clientes que coincidan con la búsqueda.");
            }

            return clientesFiltrados;
        }

        public void ValidarCliente(Cliente cliente)
        {
            if (Validador.EsVacio(cliente.TipoDocumento))
                throw new ArgumentException("Seleccione un tipo de documento.");

            if (Validador.EsVacio(cliente.NumeroDocumento))
                throw new ArgumentException("El número de documento es obligatorio.");

            if (cliente.TipoDocumento == "DNI")
            {
                if (!Validador.TieneLongitudExacta(cliente.NumeroDocumento, 8))
                    throw new ArgumentException("El DNI debe tener exactamente 8 dígitos.");

                if (Validador.SonTodosIguales(cliente.NumeroDocumento))
                    throw new ArgumentException("El DNI no puede tener todos los dígitos iguales.");
            }

            if (cliente.TipoDocumento == "RUC")
            {
                if (!Validador.TieneLongitudExacta(cliente.NumeroDocumento, 11))
                    throw new ArgumentException("El RUC debe tener exactamente 11 dígitos.");

                if (Validador.SonTodosIguales(cliente.NumeroDocumento))
                    throw new ArgumentException("El RUC no puede tener todos los dígitos iguales.");

                if (!Validador.EmpiezaCon(cliente.NumeroDocumento, "10") && !Validador.EmpiezaCon(cliente.NumeroDocumento, "20"))
                    throw new ArgumentException("El RUC debe empezar con '10' o '20'.");
            }

            if (!Validador.EsNumero(cliente.NumeroDocumento))
                throw new ArgumentException("El número de documento debe contener solo dígitos numéricos.");

            if (Validador.EsVacio(cliente.NombreCompleto))
                throw new ArgumentException("El nombre del cliente es obligatorio.");

            if (!Validador.EsNombreValido(cliente.NombreCompleto))
                throw new ArgumentException("El nombre solo debe contener letras, sin caracteres especiales ni espacios múltiples.");

            if (!Validador.EsVacio(cliente.Telefono))
            {
                if (!Validador.EsNumero(cliente.Telefono))
                    throw new ArgumentException("El teléfono debe contener solo dígitos numéricos.");

                if (!Validador.TieneLongitudExacta(cliente.Telefono, 9))
                    throw new ArgumentException("El teléfono debe tener exactamente 9 dígitos.");

                if (!Validador.EmpiezaCon(cliente.Telefono, "9"))
                    throw new ArgumentException("El teléfono debe empezar con el número 9.");
            }

            if (!Validador.EsVacio(cliente.CorreoElectronico) && !Validador.EsEmailValido(cliente.CorreoElectronico))
                throw new ArgumentException("El formato del correo electrónico no es válido.");
        }
    }
}
