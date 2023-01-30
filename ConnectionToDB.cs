using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TattooStudio
{
    public class ConnectionToDB
    {
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection("Server=localhost; Port=3306; User Id=root; Password=''; Database=tattoostudio;");
        }
    }
}
