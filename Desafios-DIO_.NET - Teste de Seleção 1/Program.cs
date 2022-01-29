

// Desafios Iniciais - GFT Start #3 .NET - Teste de Seleção 1
// Realizado por: Henrique Marchioni - 29/01/2022

string[] selections = Console.ReadLine().Split(' ');
int a = int.Parse(selections[0]);
int b = int.Parse(selections[1]);
int c = int.Parse(selections[2]);
int d = int.Parse(selections[3]);


if ( a % 2 == 0 && c > 0 && d > 0 && b > c && d > a && c + d > a + b)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}