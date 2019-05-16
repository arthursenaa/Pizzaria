using System;

namespace DesafioPizzaria {
    public class Produtos {
        static Produtos[] produtos = new Produtos[100];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        Produtos(string nome, string descricao, string categoria, float preco){
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Preco = preco;
            this.DataCriacao = DateTime.Now;
        }
        public static void CadastrarProduto(){
            string nome, desc, cat;
            float preco;

            System.Console.WriteLine("Digite o nome do Produto");
            nome = Console.ReadLine();

            System.Console.WriteLine("Descreva o Produto");
            desc = Console.ReadLine();
            
            System.Console.WriteLine("Digite o Preço");
            preco = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a categoria do produto");
            cat = Console.ReadLine();

            Produtos prod = new Produtos(nome, desc, cat, preco);
            
            Id = contador +1;

            produtos[contador] = prod;
        }

        public void ListarProdutos(){
            foreach (var item in produtos)
            {
                if (item == null)
                {
                    break;
                }
                System.Console.WriteLine("");
                
            }
        }
    } 
}  