using System;

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = (x * 3.5 + y * 7.5) / 11;
        Console.WriteLine("MEDIA = " + z.ToString("0.00000"));
    }
}