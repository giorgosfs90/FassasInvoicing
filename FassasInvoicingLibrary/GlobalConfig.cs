using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FassasInvoicingLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnector Connection { get; private set; } //= new List<IDataConnector>();
        public static void InitializeConnections (bool database)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
