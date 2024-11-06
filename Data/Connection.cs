using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class Connection
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["UAIStoreDB"].ConnectionString;
        }
    }
}
