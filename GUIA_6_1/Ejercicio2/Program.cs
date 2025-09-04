using Microsoft.Data.SqlClient;

namespace Ejercicio2
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string query = @"
SELECT f.Id, f.Tipo, f.Area, f.Ancho, f.Largo, f.Radio
FROM Figuras f
";
            string stringDeConexion = "Data Source=172.16.3.41;Initial Catalog=Guia6_1_Ejercicio1_adolf_db;User ID=admindb;Password=admindb;Pooling=False;Connect Timeout=30;Encrypt=False;Authentication=SqlPassword;Application Name=vscode-mssql;Application Intent=ReadWrite;Command Timeout=30";
            using SqlConnection conexion = new SqlConnection(stringDeConexion);
            await conexion.OpenAsync();

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataReader dataReader = await cmd.ExecuteReaderAsync();

            while (await dataReader.ReadAsync())
            {
                int id = Convert.ToInt32(dataReader["Id"]);
                int Tipo = Convert.ToInt32(dataReader["Tipo"]);
                double? area = dataReader["Area"]!=DBNull.Value ? Convert.ToDouble(dataReader["Tipo"]) : null;

                Console.WriteLine($"{id,10} | {Tipo,10} | {area,10}");
            } 
        }
    }
}
