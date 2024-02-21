using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[70];
        for (int i = 0; i < 70; i++)
        {
            arr[i] = rand.Next(101);
        }
        Console.WriteLine("Original array: ");
        for (int i = 0; i < 70; i++)
        {
            Console.WriteLine($"{i}. {arr[i]}");
        }
        Console.WriteLine();

        for (int i = 0; i < 68; i += 2)
        {
            for (int j = i; j >= 0; j -= 2)
            {
                if (arr[j] > arr[j + 2])
                {
                    (arr[j], arr[j + 2]) = (arr[j + 2], arr[j]);
                }
                else
                {
                    continue;
                }
            }
        }

        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < 70; i++)
        {
            if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i}. {arr[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{i}. {arr[i]}");
            }
        }
        Console.WriteLine();
    }
}
