using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;


namespace Proyecto_Integrador.Controller
{
    public class CotizacionController
    {
        private CotizacionRepository cotizacionRepository;

        public CotizacionController()
        {
            cotizacionRepository = new CotizacionRepository();
        }

        public string obtenerId()
        {
            List<Cotizacion> lista = cotizacionRepository.Leer();
            int numero = lista.Count + 1;
            return $"COT-{numero:D4}";
        }
        public List<Cotizacion> ObtenerCotizaciones()
        {
            return cotizacionRepository.Leer();
        }

        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            cotizacionRepository.Agregar(cotizacion);
        }

        public void EditarCotizacion(Cotizacion cotizacion, string id)
        {
            cotizacionRepository.Editar(cotizacion, id);
        }
    }
}
