using Proyecto_Integrador.Views;

namespace Proyecto_Integrador
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_prueba());
        }
    
    }
}