// 14.Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.


Console.Write("Insira o valor de A: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Insira o valor de B: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Insira o valor de C: ");
int c = int.Parse(Console.ReadLine()!);

//a
if (a > b && b > c)
    Console.WriteLine($"Ordem correta = {a}, {b}, {c}");
else if (a > c && c > b)
    Console.WriteLine($"Ordem correta = {a}, {c}, {b}");

//b
else if (b > a && a > c)
    Console.WriteLine($"Ordem correta = {b}, {a}, {c}");
else if (b > c && c > a)
    Console.WriteLine($"Ordem correta = {b}, {c}, {a}");

//c
else if (c > a && a > b)
    Console.WriteLine($"Ordem correta = {c}, {a}, {b}");
else if (c > b && b > a)
    Console.WriteLine($"Ordem correta = {c}, {b}, {a}");
else
    Console.WriteLine("Valores Iguais não permitidos!");
