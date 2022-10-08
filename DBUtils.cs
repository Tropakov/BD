using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarpushinDZ
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "university";
            string user = "root";
            string password = "2633";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
