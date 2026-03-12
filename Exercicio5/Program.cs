// 5.Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
// vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

Console.Write("Informe o salário base: ");
double salarioBase = double.Parse(Console.ReadLine()!);

Console.Write("Informe o total de vendas: ");
double totalDeVendas = double.Parse(Console.ReadLine()!);

Console.Write("Digite o percentual de comissão: ");
double percentual = double.Parse(Console.ReadLine()!);

double salarioTotal = salarioBase + totalDeVendas * (percentual / 100);

Console.WriteLine($"R${salarioTotal:F2}");