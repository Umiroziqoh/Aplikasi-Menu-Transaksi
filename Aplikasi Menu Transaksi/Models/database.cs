using MySql.Data.MySqlClient;

namespace Aplikasi_Menu_Transaksi.Models
{
    public static class Database
    {
        private static string connectionString = "server=localhost;user=root;password=;database=angkringan_food;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
