using System;

namespace DesafioPizzaria {
    public class Produtos {
        static int contadorb = 0;
        static int contadorp = 0;
        static Produtos[] produtoBebida = new Produtos[100];
        static Produtos[] produtoPizza = new Produtos[100];
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        public static void Menu () {

            do {
                System.Console.WriteLine ("-----Menu Pizzaria---");
                System.Console.WriteLine ("1 - Cadastrar Produto \n2 - Listar Produtos \n3 - Busca Por ID");

                System.Console.Write ("Digite o número da opção : ");
                int opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        System.Console.WriteLine (" ");
                        System.Console.WriteLine ("---Cadastro de Produto---");

                        System.Console.Write ("Digite o Nome do Produto : ");
                        string nome = Console.ReadLine ();
                        System.Console.WriteLine ("Descreva o Produto:");
                        string descricao = Console.ReadLine ();
                        System.Console.Write ("Digite o Preço Do Produto : ");
                        float preco = float.Parse (Console.ReadLine ());
                        //bool cadastrado ;
                        System.Console.WriteLine ("Qual a categoria do Produto ? Pizza ou Bebida :");
                        string categoria = Console.ReadLine ();
                        if (categoria.ToLower ().Equals ("pizza")) {
                            Produtos p = new Produtos ();
                            p.Id = contadorp + 1;
                            p.Nome = nome;
                            p.Descricao = descricao;
                            p.Preco = preco;
                            p.DataCriacao = DateTime.Now;

                            produtoPizza[contadorp] = p;

                            contadorp++;
                            //cadastrado = true;
                        }else if(categoria.ToLower ().Equals("bebida")){
                            Produtos p = new Produtos ();
                            p.Id = contadorb + 1;
                            p.Nome = nome;
                            p.Descricao = descricao;
                            p.Preco = preco;
                            p.DataCriacao = DateTime.Now;

                            produtoBebida[contadorb] = p;

                            contadorb++;
                            //cadastrado = true;
                        }else{
                            System.Console.WriteLine("Categoria invalida");
                        }
                        // } else {
                        //     System.Console.WriteLine ("Categoria invalida , Digite se é Pizza ou Bebida.");
                        //     cadastrado = false;
                        //     continue;
                        // }

                        break;
                    case 2:
                        System.Console.WriteLine (" ");
                        System.Console.WriteLine ("---Lista dos Produtos---");
                        System.Console.WriteLine (" ");
                        System.Console.WriteLine (" ---Bebidas---");
                        if (contadorb > 0){
                            for (int i = 0; i <= 3; i++) {
                                System.Console.WriteLine ($" Produto : {produtoBebida[i].Nome}\n Preço : {produtoBebida[i].Preco} \n ID : {produtoBebida[i].Id}");
                                System.Console.WriteLine(" ");
                            }
                        }
                        System.Console.WriteLine (" ---Pizzas--- ");
                        if (contadorp > 0){
                            for (int x = 0; x <= 3; x++) {                            
                                System.Console.WriteLine ($" Produto : {produtoPizza[x].Nome}\n Preço : {produtoPizza[x].Preco} \n ID : {produtoPizza[x].Id}");
                                System.Console.WriteLine(" ");
                            }
                        }
                        break;

                    case 3:
                        System.Console.Write ("Digite o ID do Produto : ");
                        int id = int.Parse (Console.ReadLine ());
                        foreach (var item in produtoBebida) {
                            if (item != null) {
                                System.Console.WriteLine ($" Produto : {produtoBebida[id].Nome}\n Descrição : {produtoBebida[id].Descricao}\n Categoria : Bebida \n Data de Criação : {produtoBebida[id].DataCriacao}");
                            }
                        }
                        foreach (var item in produtoPizza) {
                            if (item != null) {
                                System.Console.WriteLine ($" Produto : {produtoPizza[id].Nome}\n Descrição : {produtoPizza[id].Descricao}\n Categoria : Pizza \n Data de Criação : {produtoPizza[id].DataCriacao}");
                            }
                        }
                        break;
                }

            } while (true);
        }
    }
}