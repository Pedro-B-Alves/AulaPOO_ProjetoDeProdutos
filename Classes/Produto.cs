using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(Marca marcaPrincipal){

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do Produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            // Atribuímos nossa marca através de um método criado para cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            marcaPrincipal.AdicionarNaLista(novoProduto.Marca);

            // Atribuimos o usuário através do método construtor
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        }

        public void Listar(){
            
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine($"Código {item.Codigo}");
                Console.WriteLine($"Produto {item.NomeProduto}");
                Console.WriteLine($"Preco R$ {item.Preco}");
                Console.WriteLine($"Data de Cadastro {item.DataCadastro}");
                Console.WriteLine($"Marca {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
    }
}