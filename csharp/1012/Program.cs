using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputString = Console.ReadLine().Split(" ");
        double sideA, sideB, sideC;
        sideA = double.Parse(inputString[0]);
        sideB = double.Parse(inputString[1]);
        sideC = double.Parse(inputString[2]);
        Console.WriteLine("TRIANGULO: " + (sideA * sideC / 2).ToString("0.000"));
        Console.WriteLine("CIRCULO: " + (3.14159 * sideC * sideC).ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + (sideC * (sideA + sideB) / 2).ToString("0.000"));
        Console.WriteLine("QUADRADO: " + (sideB * sideB).ToString("0.000"));
        Console.WriteLine("RETANGULO: " + (sideA * sideB).ToString("0.000"));
    }
}