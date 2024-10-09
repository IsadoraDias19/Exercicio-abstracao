
using Ex_3___Produto;

Produto prod1 = new Produto(156802,"Leite", 10.99, 250);
Produto prod2 = new Produto(428461,"Arroz", 24.32, 150);
Produto prod3 = new Produto(237539,"Iorgute", 13.25, 200);



Console.WriteLine("O código do produto é: " + prod1.Codigo + ",nome: " + prod1.Nome + ",o preço: $" + prod1.Preco );
Console.WriteLine("O código do produto é: " + prod2.Codigo + ",nome: " + prod2.Nome + ",o preço: $" + prod2.Preco );
Console.WriteLine("O código do produto é: " + prod3.Codigo + ",nome: " + prod3.Nome + ",o preço: $" + prod3.Preco );


prod1.valorEstoque();
prod2.valorEstoque();
prod3.valorEstoque();

Console.ReadKey();