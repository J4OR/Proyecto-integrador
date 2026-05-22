using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Views.Utils
{
    public class ControlResizer
    {
        private Size originalFormSize;
        private readonly Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> controlFontSizes = new Dictionary<Control, float>();
        private readonly Form formulario;

        public ControlResizer(Form form)
        {
            formulario = form;
            originalFormSize = form.Size;
            guardarEstadoOriginal();
        }


    
        // Registra las posiciones y fuentes originales de los controles del formulario.
       
        private void guardarEstadoOriginal()
        {
            originalFormSize = formulario.Size;
      
            foreach (Control ctrl in formulario.Controls)
            {
                controlBounds[ctrl] = ctrl.Bounds;
                controlFontSizes[ctrl] = ctrl.Font.Size;
            }
        }

        // Redimensiona los controles del formulario según el nuevo tamaño.

        public void ejecutarEscalado()
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0) return;

            float xRatio = (float)formulario.Width / originalFormSize.Width;
            float yRatio = (float)formulario.Height / originalFormSize.Height;
            float fontRatio = (xRatio + yRatio) / 2;

            foreach (Control ctrl in formulario.Controls)
            {
                if (!controlBounds.ContainsKey(ctrl)) continue;

                // Escalar dimensiones físicas
                Rectangle original = controlBounds[ctrl];
                ctrl.SetBounds(
                    (int)(original.X * xRatio),
                    (int)(original.Y * yRatio),
                    (int)(original.Width * xRatio),
                    (int)(original.Height * yRatio)
                );

                // Escalar tamaño de fuente
                if (controlFontSizes.ContainsKey(ctrl))
                {
                    float originalFontSize = controlFontSizes[ctrl];
                    float newFontSize = originalFontSize * fontRatio;

                    if (newFontSize < 8f) newFontSize = 8f; // Mínimo legible

                    ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
                }
            }
        }
    }
}
