//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = {0,1,2,3,4,5,6,7,8,9,10};
        OutputArrayFromTheEnd(array, array.Length - 1);
    }

    static void OutputArrayFromTheEnd(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            OutputArrayFromTheEnd(array, index - 1);
        }
    }
}
