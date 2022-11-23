using System;

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int years = days / 365;
        days %= 365;
        Console.WriteLine("{0} ano(s)", years);
        Console.WriteLine("{0} mes(es)", days / 30);
        Console.WriteLine("{0} dia(s)", days % 30);
    }
}