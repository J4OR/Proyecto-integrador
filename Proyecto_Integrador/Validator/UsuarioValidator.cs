using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador.Validator
{
    internal class UsuarioValidator
    {
        public static Dictionary<string, string> Validar(string nombre, string telefono, string documento,
        string correo, string usuario, string contraseña, string confirmar)
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

            // DOCUMENTO
            if (string.IsNullOrWhiteSpace(documento) || documento == "Ingrese el documento de identidad")
                errores["txtDocumento"] = "El documento es obligatorio.";
            else if (!Regex.IsMatch(documento, @"^[0-9\-]+$"))
                errores["txtDocumento"] = "El documento solo puede contener números y guiones.";
            else if (documento.Length < 6 || documento.Length > 11)
                errores["txtDocumento"] = "El documento debe tener entre 6 y 11 caracteres.";

            // CORREO
            if (string.IsNullOrWhiteSpace(correo) || correo == "Ingrese el correo electrónico")
                errores["txtCorreo"] = "El correo es obligatorio.";
            else if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errores["txtCorreo"] = "El formato del correo no es válido.";

            // USUARIO
            if (string.IsNullOrWhiteSpace(usuario) || usuario == "Ingrese el nombre de usuario")
                errores["txtUsuario"] = "El usuario es obligatorio.";
            else if (usuario.Length < 4)
                errores["txtUsuario"] = "El usuario debe tener al menos 4 caracteres.";
            else if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]+$"))
                errores["txtUsuario"] = "El usuario solo puede contener letras, números y guion bajo.";

            // CONTRASEÑA
            if (string.IsNullOrWhiteSpace(contraseña) || contraseña == "Ingrese la contraseña")
                errores["txtContraseña"] = "La contraseña es obligatoria.";
            else if (contraseña.Length < 6)
                errores["txtContraseña"] = "La contraseña debe tener mínimo 6 caracteres.";
            else if (!Regex.IsMatch(contraseña, @"[0-9]"))
                errores["txtContraseña"] = "La contraseña debe tener al menos un número.";

            // CONFIRMAR
            if (string.IsNullOrWhiteSpace(confirmar) || confirmar == "Confirma la contraseña")
                errores["txtConfirmar"] = "Confirma la contraseña.";
            else if (contraseña != confirmar)
                errores["txtConfirmar"] = "Las contraseñas no coinciden.";

            return errores;
        }
    }
}
