// using Fundamentos.Models;

//Data atual do sistema

// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// Console.WriteLine("Happy Birthday Hellen!");

// int inteiro = 5;

// string a = inteiro.ToString();
// Console.WriteLine(a);

// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);

// Condições

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool venda = quantidadeCompra >0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {venda}");


// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda Inválida.");
// }
// else if (venda)
// {
//   Console.WriteLine("Venda Realizada.");
// }
// else
// {
//   Console.WriteLine("Desculpe, não temos a quantidade em estoque,");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a" || letra =="e" || letra == "i" || letra == "o" || letra =="u")
// {
//   Console.WriteLine("Vogal");
// }

//Switch Case

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;
//   default:
//     Console.WriteLine("Não é uma vogal.");
//     break;
// }

bool ehMaiorDeIdade = false;
bool altorizacao = false;

if (ehMaiorDeIdade || altorizacao)
{
  Console.WriteLine("Entrada liberada.");
}
else
{
  Console.WriteLine("Entrada negada");
}
