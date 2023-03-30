using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Produto
    {
        public string nome;
        public double preco;
        public double peso;

        public Produto(string nome, double preco, double peso)
        {
            this.nome = nome;
            this.preco = preco;
            this.peso = peso;
        }
    }
}
