using System;

namespace GestionEstudiantes.Core.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Carnet { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;

                int edad = hoy.Year - FechaNacimiento.Year;

                if (FechaNacimiento.Date > hoy.AddYears(-edad))
                    edad--;

                return edad;
            }
        }

        public string Estado { get; set; }

        public string NivelAcademico { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellidos}";
            }
        }
    }
}