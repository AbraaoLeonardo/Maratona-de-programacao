using System;

class Program
{
    static void Main()
    {
        int seconds = int.Parse(Console.ReadLine());
        int hour = seconds / 3600;
        seconds %= 3600;
        Console.WriteLine("{0}:{1}:{2}", hour, seconds / 60, seconds % 60);
    }
}