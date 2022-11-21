using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());
        float pay = float.Parse(Console.ReadLine());
        float TotalToPay = hour * pay;
        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + TotalToPay.ToString("0.00"));
    }
}