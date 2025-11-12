// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de notas: ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese la nota {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        double promedio = suma / n;
        Console.WriteLine($"Promedio final: {promedio}");





    }
}
