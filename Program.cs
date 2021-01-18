using System;
using Interace_EX.Classes;

namespace Interace_EX
{
    class Program
    {
        static void Main(string[] args)

        {

            Carrinho carrinho = new Carrinho();
            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "PlayStation 5";
            p1.Preco = 10000;

            Produto p2 = new Produto();
            p2.Codigo = 123;
            p2.Nome = "Xbox SX";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 123;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 4000;

            carrinho.Cadastrar(p1);
            carrinho.Listar();

            Console.WriteLine($"----------------------------");

            carrinho.Alterar(p1.Codigo, p3);
            carrinho.Listar();
        }
           
    }
}
