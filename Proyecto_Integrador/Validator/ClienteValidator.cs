using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Proyecto_Integrador.Validator
{
    internal class ClienteValidator
    {
        public static Dictionary<string, string> Validar(string nombre, string telefono, string identificacion, string correo)
        {
            Dictionary<string, string> errores = new Dictionary<string, string>();

            // NOMBRE
            if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ingrese el nombre completo")
                errores["txtNombre"] = "El nombre es obligatorio.";
            else if (nombre.Length < 3)
                errores["txtNombre"] = "El nombre debe tener al menos 3 caracteres.";
            else if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                errores["txtNombre"] = "El nombre solo puede contener letras.";

            // TELEFONO
            if (string.IsNullOrWhiteSpace(telefono) || telefono == "Ingrese el número de telefono")
                errores["txtTelefono"] = "El teléfono es obligatorio.";
            else if (!Regex.IsMatch(telefono, @"^\d{10}$"))
                errores["txtTelefono"] = "El teléfono debe tener exactamente 10 dígitos.";

            // IDENTIFICACION
            if (string.IsNullOrWhiteSpace(identificacion) || identificacion == "Ingrese el documento de identidad")
                errores["txtIdentificacion"] = "La identificación es obligatoria.";
            else if (!Regex.IsMatch(identificacion, @"^[0-9\-]+$"))
                errores["txtIdentificacion"] = "La identificación solo puede contener números y guiones.";
            else if (identificacion.Length < 6 || identificacion.Length > 11)
                errores["txtIdentificacion"] = "La identificación debe tener entre 6 y 11 caracteres.";

            // CORREO
            if (string.IsNullOrWhiteSpace(correo) || correo == "Ingrese el correo electrónico")
                errores["txtCorreo"] = "El correo es obligatorio.";
            else if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errores["txtCorreo"] = "El formato del correo no es válido.";

            return errores;
        }
    }
}

