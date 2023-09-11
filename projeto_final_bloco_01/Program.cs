using System;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        public static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0;
            string nome;
            int tipo = 0;
            decimal preco = 0.0M;
            int tipoProduto = 0;

            while (true)
            {

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|          BEM-VINDO A P&P JÓIAS          |");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|    1. Criar Produto                     |");
                Console.WriteLine("|    2. Ver Vitrine                       |");
                Console.WriteLine("|    3. Consultar Produtos por Categoria  |");
                Console.WriteLine("|    4. Atualizar Produto                 |");
                Console.WriteLine("|    5. Deletar Produto                   |");
                Console.WriteLine("|    6. Mudar cor de fundo                |");
                Console.WriteLine("|    0. Sair                              |");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Escolha uma opção para começar:           ");
                Console.WriteLine("                                          ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Sobre();
                        System.Environment.Exit(0);
                        break;
                    case 1:

                        Console.WriteLine("Digite o nome do Produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o tipo do Produto: ");
                            Console.WriteLine("1 - Semi Jóias");
                            Console.WriteLine("2 - Bijuterias");
                            Console.WriteLine("3 - Jóias ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o preço do Produto: ");
                        preco = Convert.ToInt32(Console.ReadLine());
                        break;

                    /*
                switch (tipoProduto)

                {
                    case 1:
                        Console.WriteLine("Digite o tipo do produto (Anel, Brinco ou Colar):");
                        tipoProduto = Console.ReadLine();
                        produto.CriarProduto(new Medicamento(produto.GerarNumero(), nome, tipo, preco, generico));

                        break;
                    case 2:
                        Console.WriteLine("Digite o fragrância do produto: ");
                        fragrancia = Console.ReadLine();
                        produto.CriarProduto(new Cosmetico(produto.GerarNumero(), nome, tipo, preco, fragrancia));
                        break;
                }

                KeyPress();
                break;
                    */
                    case 2: 
                        KeyPress();
                        break;

                    case 3:         
                        KeyPress();
                        break;
                    case 4:
                        KeyPress();
                        break;
                    case 5:
                        KeyPress();
                        break;
                    case 6:
                        KeyPress();
                        break;




                }

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