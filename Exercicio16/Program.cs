// 16.Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine("Número par");
}
else
{
    Console.WriteLine("Número ímpar");
}