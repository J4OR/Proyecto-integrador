using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Views.Utils
{
    public class LabelsUtils
    {

        public static void MostrarError(Dictionary<string, Label> labelsError, Dictionary<string, string> errores)
        {
            foreach (var entry in labelsError)
            {
                if (errores.ContainsKey(entry.Key))
                {
                    entry.Value.Text = "! " + errores[entry.Key];
                    entry.Value.Visible = true;
                }
                else
                {
                    entry.Value.Text = "";
                    entry.Value.Visible = false;
                }
            }
        }
    }
}
