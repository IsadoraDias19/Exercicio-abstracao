
using Ex_2___Aluno;


Aluno aluno1 = new Aluno(1755, "Isadora Dias", new DateTime(2007,06,19), "isadora.souza7@portalsesisp.org.br");
Aluno aluno2 = new Aluno(2490, "Victor Hugo", new DateTime(2007, 08, 20), "victor.santos36@portalsesisp.org.br");
Aluno aluno3 = new Aluno(2468, "Thiago Alves", new DateTime (2007,09,10), "thiago.alves07@portalsesisp.org.br");

Console.WriteLine("O RM é: " + aluno1.RM + ", o nome é: " + aluno1.Nome + " ,a data de nascimento é " + aluno1.Nascimento + "e o EMAIL é " + aluno1.Email);
Console.WriteLine("O RM é: " + aluno2.RM + ", o nome é: " + aluno2.Nome + " ,a data de nascimento é " + aluno2.Nascimento + "e o EMAIL é " + aluno2.Email);
Console.WriteLine("O RM é: " + aluno3.RM + ", o nome é: " + aluno3.Nome + " ,a data de nascimeto é " + aluno3.Nascimento + "e o EMAIL é " + aluno3.Email);
Console.ReadKey();
