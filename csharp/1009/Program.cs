using System;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double selling = double.Parse(Console.ReadLine());
        salary += selling * 0.15;
        Console.WriteLine("TOTAL = R$ " + salary.ToString("0.00"));
    }
}