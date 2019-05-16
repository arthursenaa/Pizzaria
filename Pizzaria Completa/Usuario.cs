using System;

namespace Pizzaria_Completa
{
    public class Usuario
    {
        static Usuario[] usuarios = new Usuario[1000];
        static int contador = 0;
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataCriacao {get;set;}

        public static void Inserir(){
            string nome;
            string email;
            string senha;

            System.Console.Write("Digite o nome do usuário : ");
            nome = Console.ReadLine();

            do
            {
             
            System.Console.WriteLine("Digite o E-Mail");
            email = Console.ReadLine();
            if(!email.Contains("@") || !email.Contains(".")){
                System.Console.WriteLine("Email inválido");
            }
            } while (!email.Contains("@") || !email.Contains("."));
            
            do
            {
                System.Console.WriteLine("Digite a senha:");
                senha = Console.ReadLine();
                
                if (senha.Length < 6){
                    System.Console.WriteLine("Senha Invalida");
                }
            } while (senha.Length < 6);

            Usuario user = new Usuario();
            user.Id = contador + 1;
            user.Nome = nome;
            user.Email = email;
            user.Senha = senha;
            user.DataCriacao = DateTime.Now;

            usuarios[contador] = user;

            contador++;
        }

        public static void EfetuarLogin(){
            string email;
            string senha;

            System.Console.WriteLine($"Digite o email:");
            email = Console.ReadLine();
            System.Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();
            
            foreach (var item in usuarios)
            {
                if(email.Equals(item.Email) && senha.Equals(item.Senha)){
                    System.Console.WriteLine("Bem Vindo a Matrix");
                }else{
                    System.Console.WriteLine("Email ou senha Invalido");
                }
            }
        }

        public static void ListarUsuario(){
            foreach (var item in usuarios)
            {   
                if(item !=null){
                System.Console.WriteLine($"ID: {item.Id} nome: {item.Nome}");
                }
            }

        }
    }
}