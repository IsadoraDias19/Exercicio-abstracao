using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01____Livro
{
    public class Livro
    {
        /* Atributos / Propriedade */
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int  Ano_Lancamento { get; set; }


        /* É necessário um método construtor para acessar as propreidades e manipular elas */
        public Livro(string titulo, string autor, string editora, int ano_lancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Ano_Lancamento = ano_lancamento;
        }

    }
}
