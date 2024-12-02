using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApplication
{
    public class DatabaseHandler
    {
        private string connectionString = "Data Source= ";
        //database source here ^^

        public List<string> Identifiers { get; set; }

        public void ViewLog() {  }
        public void MakeQuery(string query) {  }
        public void DetermineIdentifier() { }
        public  SqlConnection CreateConnection()
        {
           SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        
        }
        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
