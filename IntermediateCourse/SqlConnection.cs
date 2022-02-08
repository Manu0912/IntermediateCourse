using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
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
            return "SQL Connection Completed";
        }
    }
}
