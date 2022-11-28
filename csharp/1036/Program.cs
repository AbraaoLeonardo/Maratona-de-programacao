using System;

class Program
{
    static void Main(string[] args)
    {
        string[] data = Console.ReadLine().Split(" ");
        double a, b, c, root, r1, r2;
        a = double.Parse(data[0]);
        b = double.Parse(data[1]);
        c = double.Parse(data[2]);
        root = b * b - 4 * a * c;
        if (a == 0 || root < 0)
            Console.WriteLine("Valores Invalidos");
        else
        {
            r1 = (-b + Math.Sqrt(root)) / (2 * a);
            r2 = (-b - Math.Sqrt(root)) / (2 * a);
            Console.WriteLine("R1 = " + r1.ToString("0.00000"));
            Console.WriteLine("R2 = " + r2.ToString("0.00000"));
        }
    }
}