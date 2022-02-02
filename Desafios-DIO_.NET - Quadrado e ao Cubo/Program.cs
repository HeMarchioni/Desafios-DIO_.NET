

// Desafios Iniciais - GFT Start #4 .NET - Quadrado e ao Cubo
// Realizado por: Henrique Marchioni - 02/02/2022


int n = int.Parse(Console.ReadLine());



for (int i = 1; i <= n; i++)
{
    int inicio = i;

    Console.Write(inicio);
    inicio = inicio * i;
    Console.Write(" "+inicio);
    inicio = inicio * i;
    Console.WriteLine(" "+inicio);
}