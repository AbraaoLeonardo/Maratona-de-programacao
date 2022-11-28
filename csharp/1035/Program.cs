using System;

class Program
{
    static void Main()
    {
        string aceitos = "Valores nao aceitos";
        string[] input = Console.ReadLine().Split(" ");

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);

        if (b > c && d > a)
            if (c + d > b + a)
                if (c > 0 && d > 0)
                    if (a % 2 == 0)
                        aceitos = "Valores aceitos";

        Console.WriteLine(aceitos);
    }
}