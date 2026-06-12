using Proyecto_Integrador.Controller;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador.Validator
{
    internal class UsuarioValidator
    {
        public static Dictionary<string, string> Validar( string nombre,string telefono,string documento,
        string correo,string usuario,string contraseña,string confirmar, bool esTiempoReal = false)
        {
            Dictionary<string, string> errores = new Dictionary<string, string>();
            // NOMBRE
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ingrese el nombre completo")
                    errores["txtNombre"] = "El nombre es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(nombre) && nombre != "Ingrese el nombre completo")
            {
                if (nombre.Length < 3)
                    errores["txtNombre"] = "El nombre debe tener al menos 3 caracteres.";
                else if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    errores["txtNombre"] = "El nombre solo puede contener letras.";
            }

            // TELEFONO
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(telefono) || telefono == "Ingrese el número de telefono")
                    errores["txtTelefono"] = "El teléfono es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(telefono) && telefono != "Ingrese el número de telefono")
            {
                if (!Regex.IsMatch(telefono, @"^\d{10}$"))
                    errores["txtTelefono"] = "El teléfono debe tener 10 dígitos.";
            }

            // DOCUMENTO
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(documento) || documento == "Ingrese el documento de identidad")
                    errores["txtDocumento"] = "El documento es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(documento) && documento != "Ingrese el documento de identidad")
            {
                if (!Regex.IsMatch(documento, @"^[0-9\-]+$"))
                    errores["txtDocumento"] = "Solo números y guiones.";
                else if (documento.Length < 6 || documento.Length > 11)
                    errores["txtDocumento"] = "Debe tener entre 6 y 11 caracteres.";
            }

            // CORREO
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(correo) || correo == "Ingrese el correo electrónico")
                    errores["txtCorreo"] = "El correo es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(correo) && correo != "Ingrese el correo electrónico")
            {
                if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    errores["txtCorreo"] = "Correo no válido.";
            }

            // USUARIO
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(usuario) || usuario == "Ingrese el nombre de usuario")
                    errores["txtUsuario"] = "El usuario es obligatorio.";
            }

            if (!string.IsNullOrWhiteSpace(usuario) && usuario != "Ingrese el nombre de usuario")
            {

                if (usuario.Length < 4)
                    errores["txtUsuario"] = "Mínimo 4 caracteres.";
                else if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]+$"))
                    errores["txtUsuario"] = "Solo letras, números y _.";
            }

            // CONTRASEÑA 
            string errorPassword = "";

            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(contraseña) || contraseña == "Ingrese la contraseña")
                {
                    errorPassword = "La contraseña es obligatoria.";
                }
            }

            if (!string.IsNullOrWhiteSpace(contraseña) && contraseña != "Ingrese la contraseña")
            {
                if (contraseña.Length < 6)
                    errorPassword += "• Mínimo 6 caracteres\n";

                if (!Regex.IsMatch(contraseña, "[A-Z]"))
                    errorPassword += "• Una mayúscula\n";

                if (!Regex.IsMatch(contraseña, "[0-9]"))
                    errorPassword += "• Un número\n";

                if (!Regex.IsMatch(contraseña, @"[^a-zA-Z0-9]"))
                    errorPassword += "• Un carácter especial\n";
            }

            if (errorPassword != "")
            {
                errores["txtContraseña"] = errorPassword;
            }

            // CONFIRMAR
            if (!esTiempoReal)
            {
                if (string.IsNullOrWhiteSpace(confirmar) || confirmar == "Confirma la contraseña")
                {
                    errores["txtConfirmar"] = "Confirma la contraseña.";
                }
            }

            if (!string.IsNullOrWhiteSpace(confirmar) && confirmar != "Confirma la contraseña")
            {
                if (contraseña != confirmar)
                    errores["txtConfirmar"] = "Las contraseñas no coinciden.";
            }

            return errores;
        }
     

        public static Dictionary<string, string> validarEdicion (string nombre, string telefono, string documento, string correo, string usuario)
        {
            Dictionary<string, string> errores = new Dictionary<string, string>();
            // NOMBRE
            if (string.IsNullOrWhiteSpace(nombre))
                errores["txtNombre"] = "El nombre es obligatorio.";
            else if (nombre.Length < 3)
                errores["txtNombre"] = "El nombre debe tener al menos 3 caracteres.";
            else if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                errores["txtNombre"] = "El nombre solo puede contener letras.";
            // TELEFONO
            if (string.IsNullOrWhiteSpace(telefono))
                errores["txtTelefono"] = "El teléfono es obligatorio.";
            else if (!Regex.IsMatch(telefono, @"^\d{10}$"))
                errores["txtTelefono"] = "El teléfono debe tener exactamente 10 dígitos.";
            // DOCUMENTO
            if (string.IsNullOrWhiteSpace(documento))
                errores["txtDocumento"] = "El documento es obligatorio.";
            else if (!Regex.IsMatch(documento, @"^[0-9\-]+$"))
                errores["txtDocumento"] = "El documento solo puede contener números y guiones.";
            else if (documento.Length < 6 || documento.Length > 11)
                errores["txtDocumento"] = "El documento debe tener entre 6 y 11 caracteres.";
            // CORREO
            if (string.IsNullOrWhiteSpace(correo))
                errores["txtCorreo"] = "El correo es obligatorio.";
            else if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errores["txtCorreo"] = "El formato del correo no es válido.";
            // USUARIO
            if (string.IsNullOrWhiteSpace(usuario))
                errores["txtUsuario"] = "El usuario es obligatorio.";
            else if (usuario.Length < 4)
                errores["txtUsuario"] = "El usuario debe tener al menos 4 caracteres.";
            else if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]+$"))
                errores["txtUsuario"] = "El usuario solo puede contener letras, números y guion bajo.";
            return errores;

        }
        public static Dictionary<string, string> ValidarContraseña(string contraseña, string confirmar)
        {
            Dictionary<string, string> errores = new Dictionary<string, string>();

            if (string.IsNullOrWhiteSpace(contraseña))
                errores["txtContraseña"] = "La contraseña es obligatoria.";
            else if (contraseña.Length < 6)
                errores["txtContraseña"] = "La contraseña debe tener mínimo 6 caracteres.";
            else if (!Regex.IsMatch(contraseña, @"[0-9]"))
                errores["txtContraseña"] = "La contraseña debe tener al menos un número.";
            else if (!Regex.IsMatch(contraseña, @"[^a-zA-Z0-9]"))
                errores["txtContraseña"] = "La contraseña debe tener al menos un carácter especial.";

            if (string.IsNullOrWhiteSpace(confirmar))
                errores["txtConfirmar"] = "Confirma la contraseña.";
            else if (contraseña != confirmar)
                errores["txtConfirmar"] = "Las contraseñas no coinciden.";

            return errores;
        }
    }
}
