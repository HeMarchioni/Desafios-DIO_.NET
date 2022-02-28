


// Desafios C# - LocalizaLabs .NET Developer #2 - Dividindo X por Y
// Realizado por: Henrique Marchioni - 28/02/2022


int limit = Int32.Parse(Console.ReadLine());
for (int i = 0; i < limit; i++)
{
    string[] line = Console.ReadLine().Split(" ");
    double X = double.Parse(line[0]);
    double Y = double.Parse(line[1]);
    if ( Y != 0  )
    {
       System.Console.WriteLine( (X / Y).ToString("0.0") );

    }
    else
    {
        System.Console.WriteLine("divisao impossivel");
    }
}