using System;

class Program
{
    static void Main(string[] args)
    {
        double R = double.Parse(Console.ReadLine());
        double pi = 3.14159;
        double volume = R * R * R * pi * 4 / 3.0;
        Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
    }
}