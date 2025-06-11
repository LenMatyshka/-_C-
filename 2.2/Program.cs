using System;

static int FactorialRec(int n) // Рекурсивный факториал
{
    if (n <= 1) return 1;
    return n * FactorialRec(n - 1);
}

static int FactorialIter(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++) // Итеративный факториал
        result *= i;
    return result;
}
static int FibonacciRec(int n)
{
    if (n <= 1) return n; // Рекурсивный фибоначчи
    return FibonacciRec(n - 1) + FibonacciRec(n - 2);
}

static int FibonacciIter(int n)
{
    if (n <= 1) return n;
    int a = 0, b = 1;
    for (int i = 2; i <= n; i++) // Итеративный фибоначчи
    {
        int temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}

Console.WriteLine("Факториал 10 (рекурсивно): " + FactorialRec(10));
Console.WriteLine("Факториал 10 (итеративно): " + FactorialIter(10));
Console.WriteLine("Фибоначчи 3 (рекурсивно): " + FibonacciRec(3));
Console.WriteLine("Фибоначчи 3 (итеративно): " + FibonacciIter(3));