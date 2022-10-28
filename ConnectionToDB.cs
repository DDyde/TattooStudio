using Npgsql;
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
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=mi45as27; Database=TattooStudio;");
        }
    }
}
