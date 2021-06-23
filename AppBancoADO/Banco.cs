using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace AppBancoADO
{
    public class Banco : IDisposable
    {
        private readonly MySqlConnection connection;

        public Banco()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            connection.Open();
        }

        public void executarComando(string strCommand)
        {
            var varexecutarcomando = new MySqlCommand
            {
                CommandText = strCommand,
                CommandType = CommandType.Text,
                Connection = connection
            };

            varexecutarcomando.ExecuteNonQuery();
        }

        public MySqlDataReader CommandReturn(string strQuery)
        {
            var varCommandReturn = new MySqlCommand(strQuery, connection);
            return varCommandReturn.ExecuteReader();
        }

        public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
