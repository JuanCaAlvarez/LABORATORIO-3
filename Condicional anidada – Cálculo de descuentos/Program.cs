// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el monto de la compra: ");
        double monto = double.Parse(Console.ReadLine());
        double descuento;

        if (monto > 500)
        {
            descuento = 0.20;
        }
        else if (monto > 200)
        {
            descuento = 0.10;
        }
        else
        {
            descuento = 0.05;
        }

        double total = monto - (monto * descuento);
        Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
        Console.WriteLine($"Total a pagar: {total}");
    }
}
