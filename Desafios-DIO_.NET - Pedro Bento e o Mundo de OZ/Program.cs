



// Desafios C# - LocalizaLabs .NET Developer #2 - Pedro Bento e o Mundo de OZ
// Realizado por: Henrique Marchioni - 28/02/2022


List<string> joias = new List<string>();



do
{

    joias.Add(Console.ReadLine());

} while (!string.IsNullOrEmpty(joias[joias.Count - 1]));
        {

            var unijoias = joias.SkipLast(1).Distinct();

            System.Console.WriteLine(unijoias.Count());

        };
    
      