using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Repositorios
{
    internal interface IServicioRepositorio
    {
        void GuardarTodos(List<Servicio> servicios);

        List<Servicio> ObtenerTodos();
    }
}
