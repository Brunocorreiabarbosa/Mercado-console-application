using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Produtos produtos = new Produtos();

            Console.WriteLine("Digite o nome do produto para adicionalo:");
            string nome = (Console.ReadLine());

            /*Console.WriteLine($"Digite a quantidade de {nome} que tem no estoque ");
            int quantidade = int.Parse(Console.ReadLine());*/

            Console.WriteLine($"Digite o valor de cada {nome}.");
            double preco = double.Parse(Console.ReadLine());          
            Produtos produtos = new Produtos(nome,preco);
            Console.WriteLine(produtos);
            Console.WriteLine($"Deseja remover produtos Digite 1 para sim e 0 para nao:");
            string resposta = Console.ReadLine();

            if (resposta == "1")
            {
                Console.WriteLine("Digite a quantidade que Deseja remover");
                int quanti = int.Parse(Console.ReadLine());
                produtos.RemoverProdutos(quanti);
                Console.WriteLine(produtos);
                Console.WriteLine("Obrigado Por Usar O Nossos Sistema ate breve ...");
                Console.WriteLine("Aperte qualquer tecla Para sair...");
                Console.ReadKey();
            }
            else if (resposta == "0")
            {
                Console.WriteLine("Obrigado Por Usar O Nossos Sistema ate breve ...");
                Console.WriteLine("Aperte qualquer tecla Para sair...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Comando Invalido");
                Console.WriteLine("Aperte qualquer tecla Para sair...");
                Console.ReadKey();
            }
            
            
        }
    }
}
