using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca
    {
        int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }
        public List<Marca> Marcas = new List<Marca>();

        public void AdicionarNaLista(Marca marca){
            Marcas.Add(marca);
        }

        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();
            
            Console.WriteLine("Digite o código da marca :");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
            }
            Console.ResetColor();
        }

        public void Deletar(int cod){
            
            Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);

        }
    }
}