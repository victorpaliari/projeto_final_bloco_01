using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_final_bloco_01.Controller
{
    public class ProdutoController : IProdutoRepository
    {

        //lista para percorrer todos os produtos
        List<Produto> lista = new List<Produto>();
        int numero = 0;

        public void CadastrarProduto(Produto produto)
        {
                lista.Add(produto);
                Console.WriteLine($"O produto Nº {produto.GetId()} foi cadastrado com sucesso.");
        }

        //Método para visualizar todos os produtos
        public void ListarTodosProdutos()
        {
            foreach (var produto in lista)
            {
                produto.Visualizar();
            }
            
        }

        public void DeletarProduto(int id)
        {

            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {
                if (lista.Remove(produto) == true)
                    Console.WriteLine($"O produto número {numero} foi apagado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto numero {numero} não foi encontrado!");
                Console.ResetColor();
            }
        }


        //CASE 6
        //Método para mudar a cor do Foreground
        public void MudarForeground()
        {
            Console.WriteLine("Mudar a cor do plano de fundo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Amarelo");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 - Vermelho");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3 - Verde");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4 - Azul");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("5 - Magenta");
            Console.ResetColor();

            int opcao = 0;

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

            }

        }

        public void ConsultarProdutoPorNumero(int numero)
        {
            var produto = BuscarNaCollection(numero);
            if (produto != null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto numero {numero} não foi encontrado.");
                Console.ResetColor();
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.GetNumero());

            if (buscaProduto != null)
            {
                var index = lista.IndexOf(buscaProduto);
                lista[index] = produto;
                Console.WriteLine($"O produto Nº {produto.GetNumero()} foi atualizado com sucesso.");
            }
        }

        //Métodos Auxiliares
        //Método para buscar o produto na Collection
        public Produto? BuscarNaCollection(int numero)
        {
            foreach (var produto in lista)
            {
                if (produto.GetNumero() == numero)
                {
                    return produto;
                }
                
            }
            return null;
        }

        public int GerarNumero()
        {
            return ++numero;
        }
    }
}



