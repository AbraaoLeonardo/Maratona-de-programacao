using System;

class Program
{
    static void Main(string[] args)
    {
        float hour = float.Parse(Console.ReadLine());
        float speed = float.Parse(Console.ReadLine());
        float spent_fuel = hour * speed / 12;
        Console.WriteLine(spent_fuel.ToString("0.000"));
    }
}