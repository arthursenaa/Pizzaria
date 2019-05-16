using System;

namespace DesafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("PiTsuka");
            int resposta = 0;
            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Cadastrar Novo Usuário");
                Console.WriteLine ("2 - Efetuar Login");
                Console.WriteLine ("3 - Listar Usuários");
                Console.WriteLine ("9 - Sair");
                resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                        //Cadastrar usuário
                        Usuario.Inserir ();
                        break;

                    case 2:
                        //Login
                        Usuario.EfetuarLogin ();                        
                        Produtos.Menu();

                        break;
                    case 3:
                        //Listar usuário
                        Usuario.ListarUsuario ();

                        break;

                    case 9:
                        //sair
                        break;
                    default:
                        Console.WriteLine ("Valor Inválido!");
                        break;
                }

            } while (resposta != 9);
        }
    }
}