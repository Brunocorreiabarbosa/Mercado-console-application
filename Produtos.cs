using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Mercado
{
    internal class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string nome, double preco,int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
           
        }
        public Produtos(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos( int quant)
        {
           
          if (quant >= 1)
            {
                this.Quantidade += quant;
            }
            else
            {
                Console.WriteLine("Quantidade incorreta");
            }

        }

        public void RemoverProdutos(int quant)
        {
            if (Quantidade >= quant)
            {
               Quantidade-= quant;
            }
            else
            {
                Console.WriteLine("Quantidade Indisponivel");  
            }
        }
        public override string ToString()
        {
            return $"======================Dados Do Produto===================\n" +
                $"Produto: {Nome}\n" +
                $"Quantidade:{Quantidade}\n" +
                $"Preço unitario: {Preco.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"Valor total No Estoque: R$:{ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"==========================================================\n";
        }
    }
}