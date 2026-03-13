// 10.A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
// pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
// dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
// contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
// de pães e de broas, e depois calcular os dados solicitados.

const double paozinho = 0.12;
const double broa = 1.50;

Console.WriteLine("Digite quantos paozinhos você comprou: ");
int quantidadePaozinhos = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite quantas broas você comprou: ");
int quantidadeBroas = int.Parse(Console.ReadLine()!);

double resultadoTotal = (paozinho * quantidadePaozinhos) + (broa * quantidadeBroas);
Console.WriteLine($"A hotpão arrecadou ao fim do dia: R$ {resultadoTotal:F2}");

double contaPoupanca = resultadoTotal * 0.10;

Console.WriteLine($"A padaria guardará na poupança: R$ {contaPoupanca:F2}");