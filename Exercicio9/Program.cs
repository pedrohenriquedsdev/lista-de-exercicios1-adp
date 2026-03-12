// 9.A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
// terreno e depois exibir a área do terreno.

Console.Write("Insira o comprimento do terreno: ");
double comprimento = double.Parse(Console.ReadLine()!);

Console.Write("Insira a largura do terreno: ");
double largura = double.Parse(Console.ReadLine()!);

double area = comprimento * largura;

Console.WriteLine($"Área total do terreno: {area:F2}m²");