using Microsoft.Data.SqlClient;

namespace Ejercicio3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string query = @"
SELECT f.Id, f.Tipo, f.Area, f.Ancho, f.Largo, f.Radio
FROM Figuras f
WHERE Id=3
ORDER BY f.Id
";
            string stringDeConexion = "Data Source=172.16.3.38;Initial Catalog=Guia6_1_Ejercicio1_adolf_db;User ID=admindb;Password=admindb;Pooling=False;Connect Timeout=30;Encrypt=False;Authentication=SqlPassword;Application Name=vscode-mssql;Application Intent=ReadWrite;Command Timeout=30";
            using SqlConnection conexion = new SqlConnection(stringDeConexion);
            await conexion.OpenAsync();

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataReader dataReader = await cmd.ExecuteReaderAsync();
            Console.WriteLine($"{"Id",10} | {"Tipo",10} | {"Area",10} | {"Ancho",10} | {"Largo",10} | {"Radio",10}");

            while (await dataReader.ReadAsync())
            {
                int id = Convert.ToInt32(dataReader["Id"]);
                int Tipo = Convert.ToInt32(dataReader["Tipo"]);
                double? area = dataReader["Area"] != DBNull.Value ? Convert.ToDouble(dataReader["Tipo"]) : null;
                double? ancho = dataReader["Ancho"] != DBNull.Value ? Convert.ToDouble(dataReader["Ancho"]) : null;
                double? largo = dataReader["Largo"] != DBNull.Value ? Convert.ToDouble(dataReader["Largo"]) : null;
                double? radio = dataReader["Radio"] != DBNull.Value ? Convert.ToDouble(dataReader["Radio"]) : null;

                Console.WriteLine($"{id,10} | {Tipo,10} | {area,10} | {ancho,10} | {largo,10} | {radio,10}");
            }
        }
    }
}
