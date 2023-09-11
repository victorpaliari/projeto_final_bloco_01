using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produto
    {

        decimal preco = 0.0M;
        decimal peso = 0.0M;
        string material;
        string tipo;
        string nome;
        int tamanho = 0;

        public Produto(decimal preco, decimal peso, string material, string tipo, string nome, int tamanho)
        {
            this.preco = preco;
            this.peso = peso;
            this.material = material;
            this.tipo = tipo;
            this.nome = nome;
            this.tamanho = tamanho;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public decimal GetPeso()
        {
            return peso;
        }
        public void SetPeso(decimal peso)
        {
            this.preco = peso;
        }
        public string GetMaterial()
        {
            return material;
        }

        public void SetMaterial(string material)
        {
            this.material = material;
        }

        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)

        {
            this.nome = nome;
        }

        public int GetTamanho()
        {
            return tamanho;
        }
        public void SetTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }
        public virtual void Visualizar()
        {
            Console.WriteLine($"Nome do produto: {this.nome}.");
            Console.WriteLine($"Tipo:^{this.tipo} .");
            Console.WriteLine($"Material: {this.material}");
            Console.WriteLine($"Peso em gramas: {this.peso}");
            Console.WriteLine($"Tamanho em cm: {this.tamanho}");
            Console.WriteLine($"Preço: {this.preco}");
        }

    }
}
