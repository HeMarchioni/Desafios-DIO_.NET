

// Desafios Iniciais - GFT Start #4 .NET - Soma de Pares Consecutivos
// Realizado por: Henrique Marchioni - 02/02/2022


int x = int.Parse(Console.ReadLine());

while (x != 0)
{
    if (x % 2 ==0)
    {
        Console.WriteLine(x + (x + 2) + (x + 4) + (x + 6) + (x + 8));
        
    } 
    else
        Console.WriteLine(x+1 + (x + 3) + (x + 5) + (x + 7) + (x + 9));


    x = int.Parse(Console.ReadLine());
}