using System;
using ConsoleBanco.Metodos;


namespace ConsoleBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string op;

            do
            {
                op = menu();

                switch (op)

                {
                    case "0":
                        RegisterUser.RegisterUserMethod(); //Feito
                        break;
                    case "1":
                        UpdateUser.UpdateUserMethod(); //Feito
                        break;
                    case "2":
                        DeleteUser.DeleteUserMethod(); //Feito
                        break;
                    case "3":
                        ViewUser.ViewUserMethod(); //Erro
                        break;
                    case "4":
                        Environment.Exit(0); //Feito
                        break;

                    case null:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções: 0, 1, 2, 3 ou 4");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções: 0, 1, 2, 3 ou 4");
                        Console.ReadKey();
                        break;

                }


            } while (op != "0" || op != "1" || op != "2" || op != "3" || op != "4");

        }
        public static string menu()
        {
            Cores color = new Cores();
            Console.Clear();
            color.ColorBlue();
            Console.WriteLine("================AppBanco================");
            Console.WriteLine("=     0 - Cadastrar Usuário            =");
            Console.WriteLine("=     1 - Editar Usuário               =");
            Console.WriteLine("=     2 - Excluir Usuário              =");
            Console.WriteLine("=     3 - Listar Usuário               =");
            Console.WriteLine("=     4 - Sair                         =");
            Console.WriteLine("========================================");
            Console.WriteLine("Qual opção você deseja: ");

            color.ColorRed();
            return Console.ReadLine();
        }
    }
    
}
