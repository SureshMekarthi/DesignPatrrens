using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattren
{
    public sealed class DatabaseConnection
    {
        public SqlConnection connection { get; }
        private DatabaseConnection()
        {
            connection = new SqlConnection("");
        }

        private static readonly Lazy<DatabaseConnection> lazy = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        public static DatabaseConnection Instance { get { return lazy.Value; } }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()

        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
