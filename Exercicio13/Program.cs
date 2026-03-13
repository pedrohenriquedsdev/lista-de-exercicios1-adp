// 13.Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

Console.Write("Insira o valor de A: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Insira o valor de B: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Insira o valor de C: ");
int c = int.Parse(Console.ReadLine()!);

if (a + b < c)
    Console.WriteLine($"SIM, {a} + {b} é < que {c}");
else
    Console.WriteLine($"NÃO, {a} + {b} não é < que {c}");