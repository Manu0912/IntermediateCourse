using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private string ConnectionString;
        private TimeSpan Timeout;
        private DateTime Start;
        internal bool IsConnected;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new ArgumentException("connectionString cannot be null, empty or only a white space");
            }
            
            Timeout = timeout; 
            IsConnected = false;
        }

        public void OpenConnection()
        {   
            Start = DateTime.Now;
            var res = NewConnection();
            TimeSpan timer = DateTime.Now - Start;
            if (timer > Timeout) throw new TimeoutException("Time out");
            Console.WriteLine("{0} \nConnection string: {1}", res , ConnectionString);
            IsConnected = true;
        }

        public abstract string NewConnection();
        public abstract void CloseConnection();

    }
}
