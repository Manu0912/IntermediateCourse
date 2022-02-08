using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseConnection;
namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OracleConnection oracleConnection = new("ASDJSND",new TimeSpan(0,0,10));
            SqlConnection sqlConnection = new("ASDJSND", new TimeSpan(0, 0, 10));

            DbCommand sqlCommand = new(sqlConnection, "select * from exampleTable");
            DbCommand oracleCommand = new(oracleConnection, "select * from exampleTable");

            sqlCommand.Execute();
            oracleCommand.Execute();
        }
    }
}