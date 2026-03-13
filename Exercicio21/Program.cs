// 21.Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
// resultado.
// a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
// b. Pesquise sobre “fatorial”

Console.Write("Digite um valor A: ");
int A = int.Parse(Console.ReadLine()!);

int resultado = 1;
string sequencia = "";

for (int i = A; i >= 1; i--)
{
    resultado *= i;
    if (i == 1)
        sequencia += i;
    else
        sequencia += $"{i} x ";
}

Console.WriteLine($"{A}! = {sequencia} = {resultado}");
