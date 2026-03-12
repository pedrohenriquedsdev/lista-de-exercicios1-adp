// 3.Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
// programa deve solicitar ao usuário:
//     ● A quilometragem inicial do veículo no início da viagem.
//     ● A quilometragem final ao término da viagem.
//     ● A quantidade de combustível consumida durante a viagem (em litros).

Console.Write("Insira a quilometragem inicial do veículo no início da viagem: ");
double kmInicial = double.Parse(Console.ReadLine()!);

Console.Write("Insira a quilometragem final ao término da viagem.: ");
double kmFinal = double.Parse(Console.ReadLine()!);

Console.Write("A quantidade de combustível consumida durante a viagem (em litros): ");
double combustívelConsumido = double.Parse(Console.ReadLine()!);

double consumo = (kmFinal - kmInicial) / combustívelConsumido;

Console.WriteLine($"A cada 1km seu veículo consome {consumo}L de combustível");