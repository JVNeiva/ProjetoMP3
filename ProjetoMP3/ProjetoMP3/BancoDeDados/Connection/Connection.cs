using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMP3.BancoDeDados.Connection
{
    public class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost; database=Mp3DB; uid=root; password=; SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
