

// Desafios Iniciais - GFT Start #3 .NET - Cálculo Simples
// Realizado por: Henrique Marchioni - 28/01/2022

string[] input;

input = Console.ReadLine().Split(' ');
int n1 = int.Parse(input[1]);
double valor1 = double.Parse(input[2]);


input = Console.ReadLine().Split(' ');
int n2 = int.Parse(input[1]);
double valor2 = double.Parse(input[2]);

double total = (n1*valor1) + (n2*valor2);
Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);