using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AutoCine.conexao
{
    public class ConnectionFactory
    {
        public static MySqlConnection getConnection()
        {
            string conexao = "server = localhost; user ID = root; password =; database = cinelocal";

            return new MySqlConnection(conexao);
        }
    }
}
