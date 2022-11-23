using System;

class Program
{
    static void Main()
    {
        int notes = int.Parse(Console.ReadLine());
        Console.WriteLine(notes);
        Console.WriteLine(notes / 100 + " nota(s) de R$ 100,00");
        notes %= 100;

        Console.WriteLine((notes / 50) + " nota(s) de R$ 50,00");
        notes %= 50;

        Console.WriteLine((notes / 20) + " nota(s) de R$ 20,00");
        notes %= 20;

        Console.WriteLine((notes / 10) + " nota(s) de R$ 10,00");
        notes %= 10;

        Console.WriteLine((notes / 5) + " nota(s) de R$ 5,00");
        notes %= 5;

        Console.WriteLine((notes / 2) + " nota(s) de R$ 2,00");
        notes %= 2;

        Console.WriteLine(notes + " nota(s) de R$ 1,00");
    }
}