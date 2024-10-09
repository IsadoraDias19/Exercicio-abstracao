using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3___Produto
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Estoque { get; set; }

        public Produto(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        /* Método */
        public void valorEstoque()
        {
            Console.WriteLine($"O produto{Nome} tem {Estoque} quantidade");
            
        }
    }
}
