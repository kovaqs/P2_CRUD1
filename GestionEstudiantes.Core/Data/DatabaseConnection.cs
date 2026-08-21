using System.Data.SqlClient;

namespace GestionEstudiantes.Core.Data
{
    public static class DatabaseConnection
    {
        private const string ConnectionString =
            @"Server=.\SQLEXPRESS;
              Database=GestionEstudiantes;
              Integrated Security=True;";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}