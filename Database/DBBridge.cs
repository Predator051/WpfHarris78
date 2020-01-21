using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHarris78.Database
{
    public class DBBridge
    {
        private static SqlConnection connection;
        public static SqlConnection CreateConnection()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\Database.mdf;Integrated Security=True");
            
            return connection;
        }

        public static SqlConnection OpenConnection()
        {
            if (connection == null)
            {
                CreateConnection();
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public static SqlConnection CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }

            return connection;
        }
    }
}
