

using Ex_01____Livro;

Livro livro1 = new Livro("É assim que acaba", "Colleen Hoover", "Galera", 2018);
Livro livro2 = new Livro("A Hipótese do Amor", "Ali Hazelwood", "Arqueiro", 2022);
Livro livro3 = new Livro("O Pequeno Prícipe", "Antoine de Saint-Exupéry", "Galera", 1943);

Console.WriteLine("O titulo do seu livro é: " + livro1.Titulo + ", o autor é: " + livro1.Autor + " ,a editoria é " + livro1.Editora + "e o ano de lançamento é " + livro1.Ano_Lancamento);
Console.WriteLine("O titulo do seu livro é: " + livro2.Titulo + ", o autor é: " + livro2.Autor + " ,a editoria é " + livro2.Editora + "e o ano de lançamento é " + livro2.Ano_Lancamento);
Console.WriteLine("O titulo do seu livro é: " + livro3.Titulo + ", o autor é: " + livro3.Autor + " ,a editoria é " + livro3.Editora + "e o ano de lançamento é " + livro3.Ano_Lancamento);
Console.ReadKey();