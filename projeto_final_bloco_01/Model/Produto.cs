using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produto
    {

        public decimal preco, peso;
        public string nome;
        public int numero, id;


        public Produto(int id, decimal preco, string nome)
        {
            this.id = id;
            this.preco = preco;
            this.nome = nome;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)

        {
            this.nome = nome;
        }

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int numero)

        {
            this.numero = numero;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        public virtual void Visualizar()
        {
            Console.WriteLine($"Id do produto: {this.id}");
            Console.WriteLine($"Nome do produto: {this.nome}.");
            Console.WriteLine($"Peso em gramas: {this.peso}");
            Console.WriteLine($"Preço: {this.preco}");

        }

    }
}
