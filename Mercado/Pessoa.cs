using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Pessoa
    {
        public string nome;
        public int cpf;
        public double dinheiro;
        public Carrinho carrinho;

        public Pessoa(string nome, int cpf, double dinheiro, Carrinho carrinho)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dinheiro = dinheiro;
            this.carrinho = carrinho;


        }

        public void comprar()
        {
            if (this.dinheiro < carrinho.precototal)
            {
                Console.WriteLine("Pobre");
            }
            else
            {
               dinheiro = this.dinheiro - carrinho.precototal;
                Console.WriteLine($"Seu saldo final apos a compra foi de: {dinheiro}");

            }
        }
        public void listar()
        {

            double precocarrinhoatual = 0;

            if (carrinho.produtos.Count.Equals(0))
            {
                Console.WriteLine("Carrinho vazio");
            }

            foreach (Produto produto in carrinho.produtos)
            {
                Console.WriteLine($"{produto.nome} custa {produto.preco}");
                precocarrinhoatual += produto.preco;
            }

            Console.WriteLine($"O preço do carrinho atual é de {precocarrinhoatual}");

        }
        public void adicionar(Produto produto)
        {
            if (carrinho.pesoAtual + produto.peso > carrinho.pesomax)
            {
                Console.WriteLine("Cheio");
            }
            else
            {
                carrinho.produtos.Add(produto);
                carrinho.pesoAtual += produto.peso;
                carrinho.precototal += produto.preco;

            }


        }
        public void remover(Produto produto)
        {
            if (carrinho.produtos.Count.Equals(0))
            {
                Console.WriteLine("Carrinho vazio");
            }
            else
            {
                carrinho.produtos.Remove(produto);
                carrinho.pesoAtual -= produto.peso;
                carrinho.precototal -= produto.preco;

            }
        }
    }
}

