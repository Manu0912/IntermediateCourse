using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private DbConnection Connection { get; set; }
        private string Command { get; set; }

        public DbCommand(DbConnection connection, String command)
        {
            if(connection == null || command == null)
            {
                throw new ArgumentNullException("connection and command cannot be null");
            }
            else
            {
                Connection = connection;   
                Command = command;
            }
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Connection.CloseConnection();
        }

    }
}
