using System;
using AppBancoADO;
using AppBancoDominio;
using MySql.Data.MySqlClient;

namespace AppBancoDLL
{
    public class UsuarioDAO
    {
        private Banco db;

        public void Insert(Usuario Usuario)
        {

            var strQuery = "";
            strQuery += "insert into tbUsuario(NOME_USER, CARGO_USER, DATA_USER)";
            strQuery += string.Format("values('{0}','{1}',str_to_date('{2}','%d/%m/%Y'));", Usuario.NOME_USER, Usuario.CARGO_USER, Usuario.DATA_USER);

            using (db = new Banco())
            {
                try
                {
                    db.executarComando(strQuery);
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O Registro não pode ser inserido. Tente novamente!", e);
                    Console.WriteLine();
                }

            }
        }


       


            public void Delete(Usuario Usuario)
        {
            var strQuery = "";
            strQuery += string.Format("delete from tbUsuario where COD_USER = {0}", Usuario.COD_USER);

            using (db = new Banco())
            {
                try
                {
                    db.executarComando(strQuery);
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O Registro não pode ser deletado. Tente novamente!", e);
                    Console.WriteLine();
                }
            }
        }
        public void Update(Usuario Usuario)
        {
            var strQuery = "";
            strQuery += string.Format("update tbUsuario set ");
            strQuery += string.Format(" NOME_USER = '{0}', CARGO_USER = '{1}',DATA_USER = str_to_date('{2}','%d/%m/%Y') where COD_USER = '{3}';", Usuario.NOME_USER, Usuario.CARGO_USER, Usuario.DATA_USER, Usuario.COD_USER);


            using (db = new Banco())
            {
                try
                {
                    db.executarComando(strQuery);
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O Registro não pode ser alterado. Tente novamente!", e);
                    Console.WriteLine();
                }
            }
        }
    }
}
