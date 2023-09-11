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
        public void CriarProduto(Produto produto);
        public void ListarProdutosVirtuais();
        public void ListarProdutosFisicos();
        public void ConsultarProdutoPorNumero(int numero);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int numero);

        //Método agregado
        public void MudarForeground();
    }
}
