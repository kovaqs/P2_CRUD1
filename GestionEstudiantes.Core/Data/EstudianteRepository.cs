using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionEstudiantes.Core.Models;

namespace GestionEstudiantes.Core.Data
{
    public class EstudianteRepository
    {
        public List<Estudiante> ObtenerTodos()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            const string sql = @"
                SELECT
                    Id,
                    Carnet,
                    Nombre,
                    Apellidos,
                    Correo,
                    FechaNacimiento,
                    Estado,
                    NivelAcademico,
                    FechaRegistro
                FROM Estudiantes
                ORDER BY Apellidos, Nombre;";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantes.Add(MapearEstudiante(reader));
                    }
                }
            }

            return estudiantes;
        }


        public Estudiante ObtenerPorId(int id)
        {
            const string sql = @"
                SELECT
                    Id,
                    Carnet,
                    Nombre,
                    Apellidos,
                    Correo,
                    FechaNacimiento,
                    Estado,
                    NivelAcademico,
                    FechaRegistro
                FROM Estudiantes
                WHERE Id = @Id;";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapearEstudiante(reader);
                    }
                }
            }

            return null;
        }


        public void Crear(Estudiante estudiante)
        {
            const string sql = @"
                INSERT INTO Estudiantes
                (
                    Carnet,
                    Nombre,
                    Apellidos,
                    Correo,
                    FechaNacimiento,
                    Estado,
                    NivelAcademico
                )
                VALUES
                (
                    @Carnet,
                    @Nombre,
                    @Apellidos,
                    @Correo,
                    @FechaNacimiento,
                    @Estado,
                    @NivelAcademico
                );";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Carnet", estudiante.Carnet);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                command.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento.Date);
                command.Parameters.AddWithValue("@Estado", estudiante.Estado);
                command.Parameters.AddWithValue("@NivelAcademico", estudiante.NivelAcademico);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }


        public void Actualizar(Estudiante estudiante)
        {
            const string sql = @"
                UPDATE Estudiantes
                SET
                    Carnet = @Carnet,
                    Nombre = @Nombre,
                    Apellidos = @Apellidos,
                    Correo = @Correo,
                    FechaNacimiento = @FechaNacimiento,
                    Estado = @Estado,
                    NivelAcademico = @NivelAcademico
                WHERE Id = @Id;";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", estudiante.Id);
                command.Parameters.AddWithValue("@Carnet", estudiante.Carnet);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                command.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento.Date);
                command.Parameters.AddWithValue("@Estado", estudiante.Estado);
                command.Parameters.AddWithValue("@NivelAcademico", estudiante.NivelAcademico);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }


        public void Eliminar(int id)
        {
            const string sql = @"
                DELETE FROM Estudiantes
                WHERE Id = @Id;";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }


        public List<Estudiante> Buscar(string texto, string estado)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            const string sql = @"
                SELECT
                    Id,
                    Carnet,
                    Nombre,
                    Apellidos,
                    Correo,
                    FechaNacimiento,
                    Estado,
                    NivelAcademico,
                    FechaRegistro
                FROM Estudiantes
                WHERE
                (
                    @Texto = ''
                    OR Nombre LIKE '%' + @Texto + '%'
                    OR Apellidos LIKE '%' + @Texto + '%'
                    OR Carnet LIKE '%' + @Texto + '%'
                    OR Correo LIKE '%' + @Texto + '%'
                )
                AND
                (
                    @Estado = ''
                    OR @Estado = 'Todos'
                    OR Estado = @Estado
                )
                ORDER BY Apellidos, Nombre;";

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Texto", texto ?? string.Empty);
                command.Parameters.AddWithValue("@Estado", estado ?? string.Empty);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantes.Add(MapearEstudiante(reader));
                    }
                }
            }

            return estudiantes;
        }


        public bool ExisteCarnet(string carnet, int? ignorarId = null)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM Estudiantes
                WHERE Carnet = @Carnet";

            if (ignorarId.HasValue)
            {
                sql += " AND Id <> @Id";
            }

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Carnet", carnet);

                if (ignorarId.HasValue)
                {
                    command.Parameters.AddWithValue("@Id", ignorarId.Value);
                }

                connection.Open();

                return (int)command.ExecuteScalar() > 0;
            }
        }


        public bool ExisteCorreo(string correo, int? ignorarId = null)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM Estudiantes
                WHERE Correo = @Correo";

            if (ignorarId.HasValue)
            {
                sql += " AND Id <> @Id";
            }

            using (SqlConnection connection = DatabaseConnection.CreateConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Correo", correo);

                if (ignorarId.HasValue)
                {
                    command.Parameters.AddWithValue("@Id", ignorarId.Value);
                }

                connection.Open();

                return (int)command.ExecuteScalar() > 0;
            }
        }


        private Estudiante MapearEstudiante(SqlDataReader reader)
        {
            return new Estudiante
            {
                Id = Convert.ToInt32(reader["Id"]),
                Carnet = reader["Carnet"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Apellidos = reader["Apellidos"].ToString(),
                Correo = reader["Correo"].ToString(),
                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                Estado = reader["Estado"].ToString(),
                NivelAcademico = reader["NivelAcademico"].ToString(),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
        }

        public void CambiarEstado(int id, string estado)
        {
            const string sql = @"
        UPDATE Estudiantes
        SET Estado = @Estado
        WHERE Id = @Id;";

            using (SqlConnection connection =
                DatabaseConnection.CreateConnection())
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Estado", estado);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}