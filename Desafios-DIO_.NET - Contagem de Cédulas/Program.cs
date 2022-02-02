

// Desafios Iniciais - GFT Start #4 .NET - Contagem de Cédulas
// Realizado por: Henrique Marchioni - 02/02/2022


int totalNotas = int.Parse(Console.ReadLine());


Console.WriteLine(totalNotas);

int notas = totalNotas / 100;
Console.WriteLine($"{notas} nota(s) de R$ 100,00");
totalNotas -= notas * 100;

notas = totalNotas / 50;
Console.WriteLine($"{notas} nota(s) de R$ 50,00");
totalNotas -= notas * 50;

notas = totalNotas / 20;
Console.WriteLine($"{notas} nota(s) de R$ 20,00");
totalNotas -= notas * 20;

notas = totalNotas / 10;
Console.WriteLine($"{notas} nota(s) de R$ 10,00");
totalNotas -= notas * 10;

notas = totalNotas / 5;
Console.WriteLine($"{notas} nota(s) de R$ 5,00");
totalNotas -= notas * 5;

notas = totalNotas / 2;
Console.WriteLine($"{notas} nota(s) de R$ 2,00");
totalNotas -= notas * 2;

notas = totalNotas / 1;
Console.WriteLine($"{notas} nota(s) de R$ 1,00");
totalNotas -= notas * 1;