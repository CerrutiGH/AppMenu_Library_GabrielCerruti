using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppBancoADO;
using AppBancoDLL;
using AppBancoDominio;
namespace ConsoleBanco.Metodos
{
    class RegisterUser
    {

        public static Usuario RegisterUserMethod()
        {
            var user = new Usuario();
            var userAc = new UsuarioDAO();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite o nome do usuário");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            user.NOME_USER = Console.ReadLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite o cargo do usuário");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            user.CARGO_USER = Console.ReadLine();

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite a data de nascimento do usuário");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            user.DATA_USER = Console.ReadLine();
            Console.WriteLine();

            userAc.Insert(user);
            ViewUser.ViewUserMethod();

            return user;

        }
    }
}
