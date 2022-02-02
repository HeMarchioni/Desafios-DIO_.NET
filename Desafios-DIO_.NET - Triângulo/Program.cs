

// Desafios Iniciais - GFT Start #4 .NET - Triângulo
// Realizado por: Henrique Marchioni - 02/02/2022


string[] valor = Console.ReadLine().Split(" ");
double a = Convert.ToDouble(valor[0]);
double b = Convert.ToDouble(valor[1]);
double c = Convert.ToDouble(valor[2]);


if (a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine("Perimetro = " + (a + b + c).ToString("N1"));
}
else
    Console.WriteLine("Area = " + (((a + b) * c)/2).ToString("N1"));