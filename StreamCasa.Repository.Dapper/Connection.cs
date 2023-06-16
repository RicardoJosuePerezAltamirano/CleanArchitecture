using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace StreamCasa.Repository.Dapper
{
    public class Connection
    {
        public SqlConnection SqlConnection { get;  }
        public Connection(IConfiguration config)
        {
            SqlConnection = new SqlConnection(config["Connection"]);
        }

    }
}