using System;
using System.Collections.Generic;
using System.Linq;

// Desafios Iniciais - GFT Start #4 .NET - Compras no Supermercado
// Realizado por: Henrique Marchioni - 03/02/2022


int totalDeCasosDeTeste = int.Parse(Console.ReadLine());

for (int i = 0; i < totalDeCasosDeTeste; i++)
{

    List<string> lista = Console.ReadLine().Split(' ').Distinct().ToList();

    lista.Sort();

    foreach (var item in lista)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine();
    
}