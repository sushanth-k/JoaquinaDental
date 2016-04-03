using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ToDoListAPI.Data_Connect
{
    public class DBUtility
    {

        public SqlConnection CreateConnection()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Server=tcp:apiservices20160330040829dbserver.database.windows.net,1433;Database=jqdentaldb;User ID=dbuser@apiservices20160330040829dbserver;Password=Team6password;Encrypt=True;TrustServerCertificate=False;Connection Timeout=3;";
            return myConnection;
        }
    }
}