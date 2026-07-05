using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Repositorios
{
    internal interface IUsuarioRepositorio
    {
        void GuardarTodos(List<Usuario> usuarios);

        List<Usuario> ObtenerTodos();
    }
}
