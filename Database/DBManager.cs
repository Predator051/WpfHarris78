using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHarris78.Database
{
    public class DBManager
    {
        public static void executeNonSqlCommand(SqlCommand command)
        {
            var connection = DBBridge.OpenConnection();
            command.Connection = connection;

            command.ExecuteNonQuery();
            DBBridge.CloseConnection();
        }

        public static DataSet executeSqlQuery(string sql)
        {
            var connection = DBBridge.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DBBridge.CloseConnection();
            return ds;
        }

        public static DataSet executeSqlQuery(SqlCommand command)
        {
            var connection = DBBridge.OpenConnection();
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            DBBridge.CloseConnection();
            return ds;
        }
    }
}
