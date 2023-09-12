using projeto_final_bloco_01.Controller;
using projeto_final_bloco_01.Model;
using System;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        public static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            ProdutoController produto = new();
            
            Aneis anel = new(produto.GerarNumero(), 500.0M, "Perola Negra", "Ouro");
            produto.CadastrarProduto(anel);
            anel.Visualizar();

            Aneis anel2 = new(produto.GerarNumero(), 500.0M, "Perola Negra", "Ouro");
            produto.CadastrarProduto(anel2);
            anel2.Visualizar();

            string? nome, tipo;
            int id;
            decimal preco;
            int opcao;

            while (true)
            {

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|          BEM-VINDO A P&P JÓIAS          |");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|    1. Cadastrar Produto                 |");
                Console.WriteLine("|    2. Listar Todos os Produtos          |");
                Console.WriteLine("|    3. Consultar Produto por Id          |");
                Console.WriteLine("|    4. Atualizar Produto                 |");
                Console.WriteLine("|    5. Deletar Produto                   |");
                Console.WriteLine("|    6. Mudar cor da letra                |");
                Console.WriteLine("|    0. Sair                              |");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Escolha uma opção para começar:            ");
                Console.WriteLine("                                           ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Sobre();
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Produto");
                        do
                        {
                            Console.WriteLine("Digite o tipo do Produto: ");
                            Console.WriteLine("ouro, prata ou bronze");
                            tipo = (Console.ReadLine());

                        } while (tipo != "ouro" && tipo != "prata" && tipo != "bronze");


                        Console.WriteLine("Digite o nome do novo produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        Console.WriteLine("Digite o preço do Produto: ");
                        preco = Convert.ToInt32(Console.ReadLine());

                        if (tipo == "ouro")
                        {
                        produto.CadastrarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                        KeyPress();
                            
                        }
                        if (tipo == "prata")
                        {
                            produto.CadastrarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                            KeyPress();
                        }
                        if (tipo == "bronze")
                        {
                            produto.CadastrarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                            KeyPress();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Listar todos os produtos");
                        produto.ListarTodosProdutos();
                        break;

                    case 3:
                        Console.WriteLine("Consultar Produto por Id");
                        Console.WriteLine("Digite o ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto.ConsultarProdutoPorNumero(id);
                        KeyPress();
                        break;


                    case 4:
                        Console.WriteLine("Atualizar produtos");
                        Console.WriteLine("Digite o id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarNaCollection(id);

                        if (produtos is not null)
                        {
                            Console.WriteLine("Digite o nome do produto: ");

                            nome = Console.ReadLine();

                            nome ??= string.Empty;

                            Console.WriteLine("Digite o preço do Produto: ");
                            preco = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o tipo do Produto: ");
                            tipo = (Console.ReadLine());


                            Console.WriteLine("Digite a categoria do produto: ");
                            tipo = (Console.ReadLine());

                            if (tipo == "ouro")
                                {
                                produto.AtualizarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                                KeyPress();

                            }
                            if (tipo == "prata")
                            {
                                produto.AtualizarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                                KeyPress();
                            }
                            if (tipo == "bronze")
                            {
                                produto.AtualizarProduto(new Aneis(produto.GerarNumero(), preco, nome, tipo));
                                KeyPress();
                            }

                        }
                        KeyPress();
                        break;

                    case 5:
                        Console.WriteLine("Deletar produtos");
                        Console.WriteLine("Digite o número do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto.DeletarProduto(id);
                        KeyPress();
                        break;
                    case 6:
                        Console.WriteLine("Mudar cor da letra");
                        produto.MudarForeground();
                        KeyPress();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;

                }

                static void Sobre()
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("\n*********************************************************");
                    Console.WriteLine("\tProjeto Desenvolvido por Victor Paliari");
                    Console.WriteLine("\n\t\tvictorrpaliari@gmail.com");
                    Console.WriteLine("\n\t\tgithub.com/victorpaliari");
                    Console.WriteLine("*********************************************************");
                    Console.ResetColor();
                }

                static void KeyPress()
                {
                    do
                    {
                        Console.Write("\nPressione Enter para Continuar...");
                        consoleKeyInfo = Console.ReadKey();
                    } while (consoleKeyInfo.Key != ConsoleKey.Enter);
                }
            }
        }
    }
}