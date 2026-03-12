// 7.Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

double nota1 = 8.2;
double nota2 = 8.0;

double peso1 = 0.4;
double peso2 = 0.3;

double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
Console.WriteLine($"Média ponderada: {mediaPonderada:F2}");