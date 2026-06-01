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

        private int obtenerSiguienteNumeroId()
        {
            List<Cotizacion> lista = cotizacionRepository.Leer();
            if (lista.Count == 0)
                return 1;
            else
                return lista.Max(c => c.numero) + 1;
        }

        public string ObtenerSiguienteId()
        {
            int siguienteNumero = obtenerSiguienteNumeroId();
            return $"COT-{siguienteNumero:D4}";
        }

        public List<Cotizacion> ObtenerCotizaciones()
        {
            return cotizacionRepository.Leer();
        }

        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            cotizacionRepository.Agregar(cotizacion);
        }

        public void EditarCotizacion(Cotizacion cotizacion, int id)
        {
            cotizacionRepository.Editar(cotizacion, id);
        }
    }
}
