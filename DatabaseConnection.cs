using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkjnkhk_
{
    public class DatabaseConnection
    {
        private static SqlConnection _connection;
        private static string ConnectionString = "Data Source=shervin;Initial Catalog=EnrollmentLatest;Integrated Security=True;";
        public static SqlConnection GetConnection() { 
        
                _connection = new SqlConnection(ConnectionString);
         _connection.Open();
            return _connection;
        }
    }
}
