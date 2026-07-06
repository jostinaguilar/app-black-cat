using AppBlackCat.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Repositorios
{
    internal interface ICotizacionRepositorio
    {
        void GuardarTodos(List<Cotizacion> cotizaciones);

        List<Cotizacion> ObtenerTodos();
    }
}
