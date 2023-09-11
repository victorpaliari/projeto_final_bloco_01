using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class ProdutoFisico : Produto
    {
        string loja = string.Empty;
        public ProdutoFisico(decimal preco, decimal peso, string material, string tipo, string nome, int tamanho, string loja) : base(preco, peso, material, tipo, nome, tamanho)
        {
            this.loja = loja;
        }

        public string GetLoja()
        {
            return loja;
        }

        public void SetLoja(string loja)
        {
            this.loja = loja;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Disponível apenas em loja física.");
        }

    }
    
}
