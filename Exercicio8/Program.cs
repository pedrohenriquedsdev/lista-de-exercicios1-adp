// 8.Crie um programa para verificar se um número é primo.
// Um número primo é um número natural maior que 1 que possui exatamente dois divisores positivos distintos: 
// o número 1 e ele mesmo. Se possuir mais divisores, é um número composto. 
// O número 2 é o único primo par, sendo os demais ímpar e terminando em 1, 3, 7 ou 9. 

Console.Write("Digite um núemro para a validação de um possível primo: ");
int numero = int.Parse(Console.ReadLine()!);

bool primo = true;

if (numero <= 1)
    primo = false;


for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = fa;
        break;
    }
}

if (primo)
    Console.WriteLine($"{numero} é primo");

else
    Console.WriteLine($"{numero} NÃO é primo");