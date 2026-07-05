using AppBlackCat.Modelos;
using AppBlackCat.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Servicios
{
    internal class ServicioServicio
    {
        private readonly IServicioRepositorio _repositorio;

        public ServicioServicio(IServicioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Registrar(Servicio servicio)
        {
            Validar(servicio);

            var servicios = _repositorio.ObtenerTodos();

            servicio.Id = servicios.Count > 0 ? servicios.Max(s => s.Id) + 1 : 1;

            servicios.Add(servicio);
            _repositorio.GuardarTodos(servicios);
        }

        public List<Servicio> ObtenerTodos()
        {
            var servicios = _repositorio.ObtenerTodos();
            return servicios;
        }

        public void Validar(Servicio servicio)
        {
            //TODO: Implementar validaciones para el servicio
        }
    }
}
