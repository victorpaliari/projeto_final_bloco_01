using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class ProdutoVirtual : Produto
    {
        int frete;

        public ProdutoVirtual(decimal preco, decimal peso, string material, string tipo, string nome, int tamanho, int frete) : base(preco, peso, material, tipo, nome, tamanho)
        {
            this.frete = frete;
        }

        public int GetFrete()
        {
            return frete;
        }

        public void SetFrete(int frete)
        {
            this.frete = frete;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Disponível apenas em loja virtual.");
        }
    }
    }

