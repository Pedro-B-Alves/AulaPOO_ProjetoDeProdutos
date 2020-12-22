using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){

            Console.ResetColor();

            Usuario user = new Usuario();
            
            Logar(user);

            if(Logado){
                GerarMenu();
            }

        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "n";

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Deletar Produto");
                Console.WriteLine("4 - Cadastrar Marca");
                Console.WriteLine("5 - Listar Marca");
                Console.WriteLine("6 - Deletar Marca");
                Console.WriteLine("0 - Sair da aplicação");
                
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;

                    case "2":
                        produto.Listar();
                        break;
                        
                    case "3":
                        Console.WriteLine("Digite um código para excluir:");
                        int cod = int.Parse(Console.ReadLine());
                        marca.Deletar(cod);
                        break;

                    case "4":
                        marca.CadastrarMarca();
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Digite um código para excluir:");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;

                    default:
                        break;
                }
                
            } while (opcao != "0");
        }

        public void Logar(Usuario usuario){

            Console.WriteLine("Digite seu email:");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua Senha:");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso!");
            }else{
                Console.WriteLine("Falha ao logar na aplicação");
            }
        }

        public void Deslogar(){
            Logado = false;
        }
    }
}