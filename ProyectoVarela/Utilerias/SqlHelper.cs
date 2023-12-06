using System.Configuration;

namespace ProyectoVarela.Utilerias
{
    public static class SqlHelper
    {
        public static string GetConnectionString()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["ProyectoVarelaConnectionString"]
                .ConnectionString;

            return connectionString;
        }
    }
}
