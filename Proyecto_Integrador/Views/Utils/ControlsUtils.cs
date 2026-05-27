using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace Proyecto_Integrador.Views.Utils
{
    public class ControlsUtils
    {
        private Size originalFormSize;
        private readonly Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> controlFontSizes = new Dictionary<Control, float>();
        private readonly Form formulario;

        public ControlsUtils(Form form)
        {
            formulario = form;
            originalFormSize = form.Size;
            guardarEstadoOriginal(formulario);
        }


    
        // Registra las posiciones y fuentes originales de los controles del formulario.
       
        private void guardarEstadoOriginal(Control contenedor)
        {
            // originalFormSize = formulario.Size;

            //foreach (Control ctrl in formulario.Controls)
            //{
            //    controlBounds[ctrl] = ctrl.Bounds;
            //    controlFontSizes[ctrl] = ctrl.Font.Size;
            //}
            foreach (Control ctrl in contenedor.Controls)
            {
                controlBounds[ctrl] = ctrl.Bounds;
                controlFontSizes[ctrl] = ctrl.Font.Size;

                if (ctrl.HasChildren)
                {
                    guardarEstadoOriginal(ctrl);
                }
            }
        }

        // Redimensiona los controles del formulario según el nuevo tamaño.

        public void ejecutarEscalado()
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0) return;

            float xRatio = (float)formulario.Width / originalFormSize.Width;
            float yRatio = (float)formulario.Height / originalFormSize.Height;
            float fontRatio = (xRatio + yRatio) / 2;
            evaluarYEscalarControles(formulario, xRatio, yRatio, fontRatio);

            //foreach (Control ctrl in formulario.Controls)
            //{
            //    if (!controlBounds.ContainsKey(ctrl)) continue;

            //    // Escalar dimensiones físicas
            //    Rectangle original = controlBounds[ctrl];
            //    ctrl.SetBounds(
            //        (int)(original.X * xRatio),
            //        (int)(original.Y * yRatio),
            //        (int)(original.Width * xRatio),
            //        (int)(original.Height * yRatio)
            //    );

            //    // Escalar tamaño de fuente
            //    if (controlFontSizes.ContainsKey(ctrl))
            //    {
            //        float originalFontSize = controlFontSizes[ctrl];
            //        float newFontSize = originalFontSize * fontRatio;

            //        if (newFontSize < 8f) newFontSize = 8f; // Mínimo legible

            //        ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
            //    }
            //}
        }
        private void evaluarYEscalarControles(Control contenedor, float xRatio, float yRatio, float fontRatio)
        {
            foreach (Control ctrl in contenedor.Controls)
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
                if (ctrl.HasChildren)
                {
                    evaluarYEscalarControles(ctrl, xRatio, yRatio, fontRatio);
                }
                if (controlFontSizes.ContainsKey(ctrl))
                {
                    float originalFontSize = controlFontSizes[ctrl];
                    float newFontSize = originalFontSize * fontRatio;

                    // ESTE ES TU ESCUDO: Si el tamaño da menor a 9, lo congela en 9 para que no se destruya el diseño
                    if (newFontSize < 9f) newFontSize = 9f;

                    ctrl.Font = new Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style);
                }
            }
        }
    }    
}

