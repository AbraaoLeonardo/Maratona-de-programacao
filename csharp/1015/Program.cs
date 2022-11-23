using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, d, result;
        string[] inputData = Console.ReadLine().Split();
        a = double.Parse(inputData[0]);
        c = double.Parse(inputData[1]);
        string[] inputData2 = Console.ReadLine().Split();
        b = double.Parse(inputData2[0]);
        d = double.Parse(inputData2[1]);
        result = Math.Sqrt(((b - a) * (b - a) + (d - c) * (d - c)));
        Console.WriteLine(result.ToString("0.0000"));
    }
}