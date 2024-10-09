using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2___Aluno
{
    public class Aluno
    {
        public int RM { get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public string Email { get; set; }

        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            RM= rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }
    }
}
