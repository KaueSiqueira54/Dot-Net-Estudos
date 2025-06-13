// using Fundamentos.Models;
using Fundamentos.Commom.Models;

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

// bool ehMaiorDeIdade = false;
// bool altorizacao = false;

// if (ehMaiorDeIdade || altorizacao)
// {
//   Console.WriteLine("Entrada liberada.");
// }
// else
// {
//   Console.WriteLine("Entrada negada");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(10, 20);
// calc.Subtrair(10, 20);
// calc.Multiplicar(10, 20);
// calc.Dividir(10, 20);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Cos(30);
// calc.Tan(30);
// calc.RaizQuadeada(2);

// int numero = 2;

// for (int i = 0; i <= 10; i++)
// {
//   Console.WriteLine($"{numero} X {i} = {numero * i}");
// }

// int numero = 5;
// int i = 0;

// while (i <= 10)
// {
//   Console.WriteLine($"{numero} X {i} = {numero * i}");
//   i++;
// }

// int soma = 0, numero = 0;


// do
// {
//   Console.WriteLine("Digite um número: \n");
//   numero = Convert.ToInt32(Console.ReadLine());
//   soma += numero;
// } while (numero != 0);

// Console.WriteLine(soma);

// string opcao;
// bool exibir = true;

// while (exibir)
// {
//   Console.WriteLine("Digite a sua opção:\n");
//   Console.WriteLine("1 - Cadastrar cliente\n");
//   Console.WriteLine("2 - Buscar cliente\n");
//   Console.WriteLine("3 - Apagar cliente\n");
//   Console.WriteLine("4 - Encerrar\n");

//   opcao = Console.ReadLine();

//   switch (opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//       break;

//     case "2":
//       Console.WriteLine("Busca de cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       exibir = false;
//       break;

//     default:
//       Console.WriteLine("Opção inválida!");
//       break;
//   }
// }

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "kaue";
pessoa1.Idade = 20;
pessoa1.Apresentar();
