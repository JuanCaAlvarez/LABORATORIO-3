// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        int i = 1;
        while (i <= 20)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
            i++;
        }
    }
}
