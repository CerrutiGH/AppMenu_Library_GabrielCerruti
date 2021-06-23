using System;
using AppBancoADO;
using AppBancoDominio;
using MySql.Data.MySqlClient;
namespace ConsoleBanco.Metodos
{
    class ViewUser
    {
        
        public static Usuario ViewUserMethod()
        {
            var banco = new Banco();
            string strSelectUserCommand = "select * from tbUsuario";
            MySqlDataReader reader = banco.CommandReturn(strSelectUserCommand);
            var user = new Usuario();
            var colors = new Cores();
            colors.ColorBlue();
            while (reader.Read())
            {
                Console.WriteLine("Id: {0}, Nome: {1} , Cargo: {2} , Data: {3} ",
               reader["COD_USER"], reader["NOME_USER"], reader["CARGO_USER"], reader["DATA_USER"]);
            }
            Console.ReadKey();

            return user;

        }
    }
}
