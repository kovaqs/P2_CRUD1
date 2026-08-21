using System;
using System.Net.Mail;
using GestionEstudiantes.Core.Models;

namespace GestionEstudiantes.Core.Validation
{
    public static class EstudianteValidator
    {
        public static string Validar(Estudiante estudiante)
        {
            if (string.IsNullOrWhiteSpace(estudiante.Nombre))
                return "Debe ingresar el nombre.";

            if (string.IsNullOrWhiteSpace(estudiante.Apellidos))
                return "Debe ingresar los apellidos.";

            if (string.IsNullOrWhiteSpace(estudiante.Carnet))
                return "Debe ingresar el carnet.";

            if (string.IsNullOrWhiteSpace(estudiante.Correo))
                return "Debe ingresar el correo electrónico.";

            if (!CorreoValido(estudiante.Correo))
                return "El correo electrónico no tiene un formato válido.";

            if (estudiante.FechaNacimiento.Date >= DateTime.Today)
                return "La fecha de nacimiento no es válida.";

            if (string.IsNullOrWhiteSpace(estudiante.Estado))
                return "Debe seleccionar un estado.";

            if (string.IsNullOrWhiteSpace(estudiante.NivelAcademico))
                return "Debe ingresar el nivel académico.";

            return null;
        }


        private static bool CorreoValido(string correo)
        {
            try
            {
                MailAddress direccion = new MailAddress(correo);

                return direccion.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }
}