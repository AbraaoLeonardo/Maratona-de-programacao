using System;

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());
        double average = (x * 2 + y * 3 + z * 5) / 10;
        Console.WriteLine("MEDIA = " + z.ToString("0.0"));
    }
}