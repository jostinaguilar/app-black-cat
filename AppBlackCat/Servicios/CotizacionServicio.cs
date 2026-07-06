using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Servicios
{
    internal class CotizacionServicio
    {
        private readonly ICotizacionRepositorio _cotizacionRepositorio;

        public CotizacionServicio(ICotizacionRepositorio cotizacionRepositorio)
        {
            _cotizacionRepositorio = cotizacionRepositorio;
        }

        public void Registrar(Cotizacion nuevaCotizacion)
        {
            var cotizaciones = _cotizacionRepositorio.ObtenerTodos();

            int nuevoIdCotizacion = cotizaciones.Any() ? cotizaciones.Max(c => c.Id) + 1 : 1;
            nuevaCotizacion.Id = nuevoIdCotizacion;

            int idDetalle = 1;
            foreach (var detalle in nuevaCotizacion.Detalles)
            {
                detalle.Id = idDetalle++;
                detalle.CotizacionId = nuevoIdCotizacion;
            }

            cotizaciones.Add(nuevaCotizacion);
            _cotizacionRepositorio.GuardarTodos(cotizaciones);
        }

        public List<Cotizacion> ObtenerTodos()
        {
            var cotizaciones = _cotizacionRepositorio.ObtenerTodos();

            return cotizaciones;
        }

        public void CambiarEstado(int idCotizacion, Cotizacion.EstadoEnum nuevoEstado)
        {
            var lista = _cotizacionRepositorio.ObtenerTodos();
            var cotizacion = lista.FirstOrDefault(c => c.Id == idCotizacion);

            if (cotizacion != null)
            {
                cotizacion.Estado = nuevoEstado;
                _cotizacionRepositorio.GuardarTodos(lista);
            }
        }

        public Cotizacion ObtenerPorId(int id)
        {
            var lista = _cotizacionRepositorio.ObtenerTodos();
            var cotizacion = lista.FirstOrDefault(c => c.Id == id);

            if (cotizacion == null)
                throw new Exception("La cotización no existe.");

            return cotizacion;
        }
    }
}
