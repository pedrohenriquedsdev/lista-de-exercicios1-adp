// 12.Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8 % de
// impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

Console.Write("Insira o seu salário: ");
double salario = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Salário padrão: {salario:F2}");

double salarioComAumento = salario * 1.15;
Console.WriteLine($"Salário com aumento: {salarioComAumento:F2}");

double salarioComDesconto = salarioComAumento - (salarioComAumento * 0.08);
Console.WriteLine($"Salário com desconto: {salarioComDesconto:F2}");