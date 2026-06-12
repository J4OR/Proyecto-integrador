using Proyecto_Integrador.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;


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

        public void CambiarEstado(string id, bool nuevoEstado)
        {
            cotizacionRepository.cambiarEstado(nuevoEstado, id);
        }

        public List<Cotizacion> buscador(string texto)
        {
            return cotizacionRepository.buscador(texto);
        }
        public double CalcularSubTotalItem(Terreno terreno, Material material)
        {
            return terreno.volumen * material.precioUnidad;
        }
        public double CalcularIvaItem(Terreno terreno, Material material, double porcentajeIva)
        {
            return CalcularSubTotalItem(terreno, material) * porcentajeIva / 100;
        }
        public double CalcularSubTotal(List<Terreno> terrenos, List<Material> materiales)
        {
            double subTotal = 0;
            for (int i = 0; i < terrenos.Count; i++)
                subTotal += CalcularSubTotalItem(terrenos[i], materiales[i]);
            return subTotal;
        }
        public double CalcularIvaTotal(List<Terreno> terrenos, List<Material> materiales, double porcentajeIva)
        {
            double ivaTotal = 0;
            for (int i = 0; i < terrenos.Count; i++)
                ivaTotal += CalcularIvaItem(terrenos[i], materiales[i], porcentajeIva);
            return ivaTotal;
        }
    }
}
