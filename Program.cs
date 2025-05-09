using System.Data.Common;

Console.Clear();

    double v1, v2, v3;

Console.Write("Digite o primeiro valor: ");
    v1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
    v2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
    v3 = Convert.ToDouble(Console.ReadLine());

Console.Clear();

    Console.ForegroundColor = ConsoleColor.Red;

if (v1 >= v2)
if (v1 >= v3)
    Console.WriteLine($"O seu maior numero é: {v1}");

if (v2 >= v1)
if (v2 >= v3)
    Console.WriteLine($"O seu maior numero é: {v2}");

if (v3 >= v1)
if (v3 >= v2)
    Console.WriteLine($"O seu maior numero é: {v3}");

    Console.ResetColor();
