

// Desafios Iniciais - GFT Start #3 .NET - Múltiplos
// Realizado por: Henrique Marchioni - 28/01/2022

string[] valores = Console.ReadLine().Split(' ');
int A = int.Parse(valores[0]);

int B = int.Parse(valores[1]);

if (A % B  == 0 || B % A == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}