using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        string interval;

        if (x >= 0 && x <= 25)
            interval = "Intervalo [0,25]";
        else if (x > 25 && x <= 50)
            interval = "Intervalo (25,50]";
        else if (x > 50 && x <= 75)
            interval = "Intervalo (50,75]";
        else if (x > 75 && x <= 100)
            interval = "Intervalo (75,100]";
        else
            interval = "Fora de intervalo";
        Console.WriteLine(interval);
    }
}