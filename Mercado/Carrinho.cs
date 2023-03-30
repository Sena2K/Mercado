using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Carrinho
    {
        public List<Produto> produtos;
        public double pesoAtual;
        public double pesomax;
        public double precototal;

        public Carrinho()
        {
            this.pesoAtual = 0;
            this.pesomax = 100;
            this.precototal = 0;
            this.produtos = new List<Produto>();
        }
    }
}
