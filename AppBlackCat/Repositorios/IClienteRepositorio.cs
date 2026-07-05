using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Repositorios
{
    internal interface IClienteRepositorio
    {
        void GuardarTodos(List<Cliente> clientes);
        List<Cliente> ObtenerTodos();
    }
}
