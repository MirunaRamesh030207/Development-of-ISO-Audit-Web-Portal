using MySql.Data.MySqlClient;

namespace PROJECT_CVRDE_FINAL.Models
{
    public class DBHelper
    {
        // connection string lives here, only once, in one place
        public static string connectionString = "server=localhost;port=3306;database=complaints_db;uid=root;pwd=Miruna@007";

        // any controller can call this to get a ready connection
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}