using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        string[] inputData;
        inputData = Console.ReadLine().Split(" ");
        a = int.Parse(inputData[0]);
        b = int.Parse(inputData[1]);
        c = int.Parse(inputData[2]);
        int maior = (a + b + int.Abs(a - b)) / 2;
        int resultado = (maior + c + int.Abs(maior - c)) / 2;
        Console.WriteLine(resultado + " eh o maior");
    }
}