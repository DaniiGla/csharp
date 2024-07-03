//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

using System;
class Program
{
    static void Main()
    {
        IntegersBetween(9, -600);
    }
    static void IntegersBetween(int m, int n)
    {
        if (m < n)
        {
            if (m - 1 <= n)
            {
                if (n > m + 1)
                {
                    IntegersBetween(m, n - 1);
                    if (n > 1)
                    {
                        Console.Write(n - 1 + " ");
                    }
                }
            }
        }

        else if (m > n + 1)
        {
            IntegersBetween(n, m - 1);
            if (m > 1)
            {
                Console.Write(m - 1 + " ");
            }
        }
    }

}




