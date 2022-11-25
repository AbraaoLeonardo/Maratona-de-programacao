using System;

class Program
{
    static void Main()
    {
        int notes, moedas;
        string[] result = Console.ReadLine().Split(".");
        moedas = int.Parse(result[1]);
        notes = int.Parse(result[0]);
        Console.WriteLine("NOTAS:");
        Console.WriteLine(notes / 100 + " nota(s) de R$ 100.00");
        notes %= 100;

        Console.WriteLine((notes / 50) + " nota(s) de R$ 50.00");
        notes %= 50;

        Console.WriteLine((notes / 20) + " nota(s) de R$ 20.00");
        notes %= 20;

        Console.WriteLine((notes / 10) + " nota(s) de R$ 10.00");
        notes %= 10;

        Console.WriteLine((notes / 5) + " nota(s) de R$ 5.00");
        notes %= 5;

        Console.WriteLine((notes / 2) + " nota(s) de R$ 2.00");
        notes %= 2;
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(notes + " nota(s) de R$ 1.00");
        Console.WriteLine((moedas / 50) + " moedas(s) de R$ 0.50");
        moedas %= 50;

        Console.WriteLine((moedas / 25) + " moedas(s) de R$ 0.25");
        moedas %= 25;

        Console.WriteLine((moedas / 10) + " moedas(s) de R$ 0.10");
        moedas %= 10;

        Console.WriteLine((moedas / 5) + " moedas(s) de R$ 0.05");
        moedas %= 5;

        Console.WriteLine((moedas) + " moedas(s) de R$ 0.01");
    }
}