using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class OracleConnection: DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void CloseConnection()
        {
            if (IsConnected)
            {
                Console.WriteLine("Connection Closed\n");
                IsConnected = false;
            }
        }

        public override string NewConnection()
        {
            return "Oracle Connection Completed";
        }
    }
}
