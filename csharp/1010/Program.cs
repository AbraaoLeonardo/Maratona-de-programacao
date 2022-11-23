using System;

class Program
{
    static void Main(string[] args)
    {
        float totalToPay = 0;
        for (int i = 0; i < 2; i++)
        {
            string[] inputData;
            inputData = Console.ReadLine().Split(" ");
            totalToPay += (float.Parse(inputData[1]) * float.Parse(inputData[2]));
        }
        Console.WriteLine("VALOR A PAGAR: R$ " + totalToPay.ToString("0.00"));
    }
}