using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoDLL;
using AppBancoDominio;
namespace ConsoleBanco.Metodos
{
    class DeleteUser
    {
        public static Usuario DeleteUserMethod()
        {
            Cores cores = new Cores();
            var user = new Usuario();
            var userAc = new UsuarioDAO();
            cores.ColorBlue();
            Console.WriteLine("Coloque o código do usuário");
            cores.ColorRed();
            try
            {
                user.COD_USER = int.Parse(Console.ReadLine());
            }
            catch
            {

            }

            userAc.Delete(user);
            ViewUser.ViewUserMethod();

            Console.ReadKey();
            return user;
        }
    }
}
