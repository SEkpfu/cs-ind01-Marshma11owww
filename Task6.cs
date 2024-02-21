using System;
using System.Dynamic;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int[] arr = new int[s];
        for (int i = 0; i < s; i++)
        {
            Console.Write($"Enter {i} Element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Original array: ");
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine($"{i}. {arr[i]}");
        }
        Console.WriteLine();

        for (int i = 0; i < s; i++)
        {
            if (arr[i] == n)
            {
                arr[i] = 0;
            }
        }

        for (int i = 0; i < s; i++)
        {
            for (int j = i; j < s - 1; j++)
            {
                if (arr[j] == 0)
                {
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = 0;
                    }
                }
            }
        }

        Console.WriteLine("Array without entered number: ");
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine($"{i}. {arr[i]}");
        }
        Console.WriteLine();
    }
}
