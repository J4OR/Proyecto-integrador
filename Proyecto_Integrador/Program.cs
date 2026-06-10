using Proyecto_Integrador.Views;
using Proyecto_Integrador.Views.Cotizaciones;

namespace Proyecto_Integrador
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    
    }
}