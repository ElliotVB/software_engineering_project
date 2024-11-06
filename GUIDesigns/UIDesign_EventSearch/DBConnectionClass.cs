using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace UIDesign_EventSearch
{
    //Creates a connection to the database
    internal class DBConnectionClass
    {
        //private object of the class itself
        private static DBConnectionClass _instance;

        //connection string
        private string connStr;

        //connection to the DB
        private SqlConnection connToDB;

        //constructor
        private DBConnectionClass()
        {
            connStr = Properties.Settings.Default.eventDatabaseConnString;
        }


        //METHODS

        //Static method which creates a unique object of the class itself
        public static DBConnectionClass getInstanceOfDBConnection()
        {
            //only creates object if it doesn't already exist
            if (_instance == null)
                _instance = new DBConnectionClass();
            return _instance;
        }

        //Returns a data set built based on the query sent as parameter
        public DataSet getDataSet(string sqlQuery)
        {
            //create empty dataset
            DataSet dataset = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open the connection
                connToDB.Open();

                //create dataAdapter to send query to DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in dataset
                dataAdapter.Fill(dataset);
            }

            return dataset;
        }
    }
}
