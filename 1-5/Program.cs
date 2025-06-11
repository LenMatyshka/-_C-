using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны треугольника 1:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите стороны треугольника 2 :");
        int a2 = Convert.ToInt32(Console.ReadLine());
        int b2 = Convert.ToInt32(Console.ReadLine());
        int c2 = Convert.ToInt32(Console.ReadLine());

      
        int max1 = Math.Max(a1, Math.Max(b1, c1));
        int min1 = Math.Min(a1, Math.Min(b1, c1));
        int mid1 = a1 + b1 + c1 - max1 - min1;

       
        int max2 = Math.Max(a2, Math.Max(b2, c2));
        int min2 = Math.Min(a2, Math.Min(b2, c2));
        int mid2 = a2 + b2 + c2 - max2 - min2;

    
        if (max1 * mid2 == max2 * mid1 && mid1 * min2 == mid2 * min1)
        {
            Console.WriteLine("Треугольники подобны");
        }
        else
        {
            Console.WriteLine("Треугольники не подобны");
        }
    }
}
