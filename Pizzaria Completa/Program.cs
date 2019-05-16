using System;

namespace Pizzaria_Completa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PiTsuka");
            int resposta = 0;
            do
            {
                System.Console.WriteLine("Selecione uma opção \n 1 - Cadastrar Novo Usuário \n 2 - Efetuar Login \n 3 - Listar Usuários \n 9 - Sair");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {   
                    case 1:
                        Usuario.Inserir();
                    break;
                    case 2:
                        Usuario.EfetuarLogin();
                    break;
                    case 3:
                    Usuario.ListarUsuario();
                    break;
                    default:
                        System.Console.WriteLine("Valor Inválido!!!");
                    break;
                }
            } while (true);
        }
    }
}
