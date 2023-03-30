namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Pessoa pessoa = new Pessoa(" bonita ", 1233231, 100.90, carrinho);


            Produto produto1 = new Produto("Maça", 19.90, 20);
            Produto produto2 = new Produto("pera", 19.90, 20);


            pessoa.adicionar(produto1);
            pessoa.remover(produto2);
            pessoa.adicionar(produto1);
            pessoa.listar();
            pessoa.comprar();

            
        }
    }
}