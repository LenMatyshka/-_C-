using System;
class Program
{
    static void Main()
    {
        Console.Write("введите a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("введите b = ");
        int b = int.Parse(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("Деление на ноль");
            return;
        }

        int quotient = 0;
        int absA = Math.Abs(a);
        int absB = Math.Abs(b);

        while (absA >= absB)
        {
            absA -= absB;
            quotient++;
        }

        if ((a < 0 && b > 0) || (a > 0 && b < 0))
            quotient = -quotient;

        Console.WriteLine($"Неполное частное: {quotient}");
    }
}