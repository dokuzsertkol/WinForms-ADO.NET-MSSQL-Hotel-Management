using System.Data.SqlClient;

namespace HOTELAPP.Helpers
{
    public class ConfigureSQL
    {
        public SqlConnection Sql;
        public ConfigureSQL()
        {
            string connectionString = "your connection string here";
            Sql = new SqlConnection(connectionString);
        }
    }
}
