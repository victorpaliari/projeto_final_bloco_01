using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Aneis : Produto
    {
        private string tipo;
        public Aneis(int id, decimal preco, string nome, string tipo) : base(id, preco, nome)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Anel de {this.tipo}.");
        }



    }
}
