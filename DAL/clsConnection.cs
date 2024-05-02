using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsConnection
    {
        public static string getConnectionString()
        {
            string dbName =
                    "server=alessandroleotta.database.windows.net;" +
                    "database=alessandroDB;" +
                    "Uid=prueba;" +
                    "pwd=fernandoG321;" +
                    "trustServerCertificate = true";
            return dbName;
        }
    }
}
