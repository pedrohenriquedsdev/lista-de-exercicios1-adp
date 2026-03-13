// 20.Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
// tabuada na forma:
// ● 0 x N = 0,
// ● 1 x N = 1N,
// ● 2 x N = 2N,
// .
// .
// .
// ● 10 x N = 10N.

Console.Write("Digite um valor de 1 - 10: ");
int n = int.Parse(Console.ReadLine()!);

int resultado;

for (int i = 1; i <= 10; i++)
{
    resultado = n * i;
    Console.WriteLine($"{n} x {i} = {resultado}");
}