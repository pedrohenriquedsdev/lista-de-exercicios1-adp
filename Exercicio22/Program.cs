// 22.Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

// A sequência de Fibonacci é uma sucessão infinita de números inteiros, começando por 0 e 1, 
// onde cada termo subsequente é a soma dos dois anteriores (\(0, 1, 1, 2, 3, 5, 8, 13, 21, 34)


int a = 0;
int b = 1;

Console.Write("Digite um núemro: ");
int numero = int.Parse(Console.ReadLine()!);

while (a <= numero)
{
    Console.WriteLine(a);
    int soma = a + b;
    a = b;
    b = soma;
}