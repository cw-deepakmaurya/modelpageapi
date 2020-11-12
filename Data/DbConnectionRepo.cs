using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace modelpage.Data
{
    public class DbConnectionRepo
    {
        private readonly IConfiguration _config;

        public DbConnectionRepo(IConfiguration config )
        {
            _config = config;
        }

        public MySqlConnection Connection{
            get
            {
                return new MySqlConnection(_config.GetConnectionString("modelPageDbString"));
            }
        }
    }
}