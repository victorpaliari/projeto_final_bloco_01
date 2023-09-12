using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IProdutoRepository
    {
        //Métodos Crud
        public void CadastrarProduto(Produto produto);
        public void ListarTodosProdutos();
        public void ConsultarProdutoPorNumero(int numero);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int id);

        //Método agregado
        public void MudarForeground();

    }
}
