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

        public void CambiarEstado(string id)
        {
            List<Cotizacion> lista = cotizacionRepository.Leer();

            Cotizacion cot = lista.FirstOrDefault(c => c.id == id);

            if (cot != null)
            {
                cot.estado = !cot.estado;
                cotizacionRepository.Editar(cot, id);
            }
        }

    //    public (bool ok, Cotizacion cot, string mensaje) GenerarCotizacion(
    //Cliente cliente,
    //Material material,
    //double volumen,
    //string descripcion)
    //    {
    //        Terreno terreno = new Terreno();
    //        terreno.volumen = volumen;

    //        Cotizacion cot = new Cotizacion(
    //            obtenerId(),
    //            cliente,
    //            terreno,
    //            material
    //        );

        //    AgregarCotizacion(cot);

        //    return (true, cot, "Cotización generada correctamente.");
        //}
    }
}
