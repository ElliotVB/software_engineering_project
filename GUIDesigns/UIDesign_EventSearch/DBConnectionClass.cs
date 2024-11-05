using System;
using System.Collections.Generic;
using System.Data.Common;
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
        //Private object of the class itself
        private static DBConnectionClass _instance;

        //Connection string
        private string connStr;

        //Connection to the DB
        private SqlConnection connToDB;

        //Constructor
        private DBConnectionClass()
        {
            connStr = Properties.Settings.Default.eventDatabaseConnString;
        }


        //METHODS

        //Static method which creates a unique object of the class itself
        public static DBConnectionClass getInstanceOfDBConnection()
        {
            //Only creates object if it doesn't already exist
            if (_instance == null)
                _instance = new DBConnectionClass();
            return _instance;
        }

        //Returns a data set built based on the query sent as parameter
        public DataSet
    }
}
