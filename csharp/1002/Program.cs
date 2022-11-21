using System;
class Program
{
    static void Main(string[] args)
    {
        double R = double.Parse(Console.ReadLine());
        double a = R * R * 3.14159;
        Console.WriteLine("A=" + a.ToString("0.0000"));
    }
}