using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Integrador.Models;
using Proyecto_Integrador.Repository;

namespace Proyecto_Integrador.Controller
{
    public class FacturaController
    {
        FacturaRepository facturaRepository;

        public FacturaController()
        {
            facturaRepository = new FacturaRepository();
        }

        public string obtenerId()
        {
            List<Factura> lista = facturaRepository.Leer();
            int numero = lista.Count + 1;
            return $"FAC-{numero:D4}";
        }

        public List<Factura> ObtenerFacturas()
        {
            return facturaRepository.Leer();
        }

        public void AgregarFactura(Factura factura)
        {
            facturaRepository.Agregar(factura);
        }
        public void cambiarEstado(string id, bool nuevoEstado)
        {
            facturaRepository.cambiarEstado(id, nuevoEstado);
        }
        public List<Factura> buscador(string texto)
        {
            return facturaRepository.buscador(texto);
        }
    }
}
