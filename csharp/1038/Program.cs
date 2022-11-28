using System;

class Program
{
    static void Main(string[] args)
    {
        string[] data = Console.ReadLine().Split(" ");
        int product = int.Parse(data[0]);
        int quantity = int.Parse(data[1]);
        double[] price = { 4.0, 4.5, 5.0, 2.0, 1.5 };
        double totalToPay = price[product - 1] * quantity;
        Console.WriteLine("Total: R$ " + totalToPay.ToString("0.00"));
    }
}