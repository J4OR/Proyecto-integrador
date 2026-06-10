using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.Views.Utils
{
    public class ControlsUtils
    {
        private readonly Size originalFormSize;
        private readonly Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> controlFontSizes = new Dictionary<Control, float>();
        private readonly Form formulario;

        public ControlsUtils(Form form)
        {
            formulario = form;
            originalFormSize = form.ClientSize;
            guardarEstadoOriginal(formulario);
        }

        private void guardarEstadoOriginal(Control contenedor)
        {
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

        public void ejecutarEscalado()
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)formulario.ClientSize.Width / originalFormSize.Width;
            float yRatio = (float)formulario.ClientSize.Height / originalFormSize.Height;
            float fontRatio = Math.Min(xRatio, yRatio);

            evaluarYEscalarControles(formulario, xRatio, yRatio, fontRatio);
        }

        private void evaluarYEscalarControles(Control contenedor, float xRatio, float yRatio, float fontRatio)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (!controlBounds.ContainsKey(ctrl))
                    continue;

                Rectangle original = controlBounds[ctrl];

               
                ctrl.SetBounds(
                    (int)(original.X * xRatio),
                    (int)(original.Y * yRatio),
                    (int)(original.Width * xRatio),
                    (int)(original.Height * yRatio)
                );
 
                if (!(ctrl is NumericUpDown) && controlFontSizes.ContainsKey(ctrl))
                {
                    float originalFontSize = controlFontSizes[ctrl];
                    float newFontSize = originalFontSize * fontRatio;

                    if (newFontSize < 8f)
                        newFontSize = 8f;

                    ctrl.Font = new Font( ctrl.Font.FontFamily,newFontSize, ctrl.Font.Style );
                }

                if (ctrl.HasChildren)
                {
                    evaluarYEscalarControles(ctrl, xRatio, yRatio, fontRatio);
                }
            }
        }
    }
}