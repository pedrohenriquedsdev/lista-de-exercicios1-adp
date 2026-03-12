// 2.Crie um programa para calcular o volume de um Cilindro

//double para cálculos que não utilizem números inteiros

// Passo a passo para calcular o volume: 
// 1 - Identifique o raio(\(r\)): Se for dado o diâmetro, divida por 2 para encontrar o raio.
// 2 - Identifique a altura (\(h\)): A medida entre as duas bases circulares.
// 3 - Calcule a área da base: Eleve o raio ao quadrado e multiplique por \(\pi \) (Área = \(\pi r^{2}\)).
// 4 - Calcule o volume: Multiplique a área da base pela altura (\(V=\text{Área\ da\ Base}\times h\)). YouTube +4

Console.WriteLine("===================================");
Console.WriteLine("Como deseja iniciar o processo?");
Console.WriteLine("===================================");
Console.WriteLine("Digite 1 - para informar o Raio.");
Console.WriteLine("Digite 2 - para informar o Diâmetro.");
Console.WriteLine("===================================");


string opcaoSelecionada = Console.ReadLine()!;

switch (opcaoSelecionada)
{
    case "1":
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("Inserindo os valores.");
        Console.WriteLine("======================");
        Console.Write("Insira o valor do raio: ");
        double raio = double.Parse(Console.ReadLine()!);

        Console.Write("Insira o valor da altura: ");
        double altura = double.Parse(Console.ReadLine()!);
        Console.WriteLine("======================");

        double area = Math.PI * (raio * raio);

        double volume = area * altura;

        Console.WriteLine("======================");
        Console.WriteLine($"O valor do volume é = {volume}");
        Console.WriteLine("======================");
        Console.ReadLine();
        break;

    case "2":
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("Inserindo os valores.");
        Console.WriteLine("======================");
        Console.Write("Insira o valor do diâmetro: ");
        double diametro = double.Parse(Console.ReadLine()!);

        raio = diametro / 2;

        Console.Write("Insira o valor da altura: ");
        altura = double.Parse(Console.ReadLine()!);
        Console.WriteLine("======================");

        area = Math.PI * (raio * raio);

        volume = area * altura;

        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine($"O valor do volume é = {volume}");
        Console.WriteLine("======================");
        Console.ReadLine();
        break;

    default:
        Console.Clear();
        Console.WriteLine("Opção inválida. Por favor, digite uma das opções válidas!");
        break;
}