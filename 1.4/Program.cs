using System;
public class Program
{
    public static void Main(string[] args)
    {
        int a, b, c, res, count;

        Console.WriteLine("Введите три числа:");

        Console.WriteLine("первое:");
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Ошибка: Введите целое число.");
            return;
        }

        Console.WriteLine("второе:");
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Ошибка: Введите целое число.");
            return;
        }

        Console.WriteLine("третье:");
        if (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Ошибка: Введите целое число.");
            return;
        }

        res = 0;

        for (int i = 0; i < 32; i++)
        {
                     count = ((a >> i) & 1) + ((b >> i) & 1) + ((c >> i) & 1);

                        if (count >= 2)
            {
                res |= (1 << i);
            }
        }

        Console.WriteLine($"Новое число: {res}");
    }
}