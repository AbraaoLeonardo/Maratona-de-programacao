using System;

class Program
{
    static void Main(string[] args)
    {
        float spend_fuel, comsuption;
        int distance = int.Parse(Console.ReadLine());
        spend_fuel = float.Parse(Console.ReadLine());
        comsuption = distance / spend_fuel;
        Console.WriteLine(comsuption.ToString("0.000") + " km/l");
    }
}