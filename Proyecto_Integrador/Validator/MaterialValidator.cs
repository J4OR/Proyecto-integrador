using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Proyecto_Integrador.Validator
{
    public class MaterialValidator
    {

        public static Dictionary<string, string> Validar(string nombre, string precio)
        {
            Dictionary<string, string> errores = new Dictionary<string, string>();

            // NOMBRE
            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ingrese el nombre completo")
                errores["txtNombre"] = "El nombre es obligatorio.";
            else if (nombre.Length < 3)
                errores["txtNombre"] = "El nombre debe tener al menos 3 caracteres.";
            else if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                errores["txtNombre"] = "El nombre solo puede contener letras.";


            // PRECIO
            if (string.IsNullOrWhiteSpace(precio) || precio == "Ingrese el precio")
                errores["txtPrecio"] = "El precio es obligatorio.";
            else if (!double.TryParse(precio, out double precioConvertido))
                errores["txtPrecio"] = "El precio debe ser un número válido.";
            else if (precioConvertido <= 0)
                errores["txtPrecio"] = "El precio debe ser mayor que cero.";

            return errores;
        }
    }
 
}
